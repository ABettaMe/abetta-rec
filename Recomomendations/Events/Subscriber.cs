using System;
using System.Threading;
using StackExchange.Redis;

namespace Recommendations.Events
{
    public class MetricUpdateSubscriber
    {
        public MetricUpdateSubscriber()
        {
        }

        public static void Register(ISubscriber subscriber)
        {
            subscriber.Subscribe("METRIC_UPDATED", (channel, message) =>
            {
                Console.WriteLine("Got notification: " + (string)message);
            });

            Thread.Sleep(5000);
            var metricValue = new MetricValue() { Value = 10, Date = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.UtcNow) };
            var metric = new Metric()
            {
                Name = "Weight",
                UnitValue = "Kilos",
                LessIsBetter = true
            };
            metric.Value.Add(metricValue);

            subscriber.Publish("METRIC_UPDATED", NReJSON.NReJSONSerializer.SerializerProxy.Serialize<Metric>(metric));
        }
    }
}
