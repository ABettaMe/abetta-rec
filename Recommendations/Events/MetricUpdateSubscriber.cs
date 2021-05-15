using System;
using System.Linq;
using System.Threading;
using Accord.Statistics.Testing;
using Google.Protobuf;
using Recommendations.Connections;
using StackExchange.Redis;

namespace Recommendations.Events
{
    public class MetricUpdateSubscriber
    {
        public static readonly string METRIC_ADDED = "abettame:rec:metric-value-added";
        public static readonly string EXPERIMENT_KEY_PREFIX = "experiments:";

        public static void Register()
        {
            var subscriber = RedisManager.GetSubscriber();
            subscriber.Subscribe(METRIC_ADDED, (channel, experimentId) =>
            {
                Console.WriteLine("Got notification for experiment: " + (string)experimentId);
                var experimentString = RedisManager.JsonGet<string>(EXPERIMENT_KEY_PREFIX + experimentId);

                var experiment = new JsonParser(JsonParser.Settings.Default).Parse<Experiment>(experimentString);
                Console.WriteLine("Retrieved experiment: " + (string)experiment.Name);

                var changeDetected = false;
                foreach (var metricControl in experiment.MetricsControl)
                {
                    var metricName = metricControl.Name;
                    var metricTreatment = experiment.MetricsTreatment.Where(x => x.Name == metricName).FirstOrDefault();

                    if (metricTreatment == null)
                    {
                        Console.WriteLine($"Did not find metric {metricName} in both control and treatment");
                    }

                    var controlValues = metricControl.Value.Select(x => x.Value);
                    var treatmentValues = metricTreatment.Value.Select(x => x.Value);

                    var samples = new double[][]
                    {
                        controlValues.ToArray(),
                        treatmentValues.ToArray()
                    };

                    var anova = new OneWayAnova(samples);
                    var fTest = anova.FTest;

                    if (fTest.PValue > 0.05)
                    {
                        Console.WriteLine($"Metric {metricName} does not have significance");

                        // Non significant difference
                        continue;
                    }

                    changeDetected = true;
                    var isMovementPositive = fTest.Hypothesis == TwoSampleHypothesis.FirstValueIsGreaterThanSecond &&
                                             metricControl.LessIsBetter;

                    experiment.Recommendations.Add(new Recommendation()
                    {
                        Id = Guid.NewGuid().ToString(),
                        AvgControl = controlValues.Average(),
                        AvgTreatment = treatmentValues.Average(),
                        MetricControl = experiment.MetricsControl[0],
                        MetricTreatment = experiment.MetricsTreatment[0],
                        PValue = fTest.PValue
                    });
                }

                if (changeDetected)
                {
                    RedisManager.JsonSet(EXPERIMENT_KEY_PREFIX + experiment.Id, experiment.ToString());
                }
            });

            //for (var i = 0; i < 1; i++ )
            //{
            //    Thread.Sleep(500);
            //    Console.WriteLine("Testing connection: " + i.ToString());
            //    SubscriberTest.TestingConnection(subscriber);
            //}
        }
    }
}
