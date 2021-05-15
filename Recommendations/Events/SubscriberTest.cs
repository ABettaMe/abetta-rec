using System;
using Recommendations.Connections;
using StackExchange.Redis;

namespace Recommendations.Events
{
    public class SubscriberTest
    {
        public static void TestingConnection(ISubscriber subscriber)
        {
            var experiment = new Experiment()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Antonis is great " + new Random().NextDouble(),
            };
            experiment.MetricsControl.Add(NewMetric());
            experiment.MetricsTreatment.Add(NewMetric(2));

            var result = RedisManager.JsonSet(MetricUpdateSubscriber.EXPERIMENT_KEY_PREFIX + experiment.Id, experiment.ToString());
            subscriber.Publish(MetricUpdateSubscriber.METRIC_ADDED, experiment.Id);
        }

        public static Metric NewMetric(double baseValue = 10)
        {
            var metric = new Metric()
            {
                Name = "Weight",
                UnitValue = "Kilos",
                LessIsBetter = true
            };
            metric.Value.Add(GenerateMetric(baseValue));
            metric.Value.Add(GenerateMetric(baseValue));
            metric.Value.Add(GenerateMetric(baseValue));
            metric.Value.Add(GenerateMetric(baseValue));
            return metric;
        }

        public static MetricValue GenerateMetric(double baseValue = 10)
        {
            return new MetricValue()
            {
                Value = baseValue + new Random().NextDouble(),
                Date = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.UtcNow)
            };
        }
    }
}
