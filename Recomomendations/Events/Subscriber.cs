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
            subscriber.Publish("METRIC_UPDATED", "Hello there matey");
        }
    }
}
