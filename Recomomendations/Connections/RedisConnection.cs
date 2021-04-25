using System;
namespace Recommendations.Connections
{
    public class RedisConnection
    {
        public RedisConnection()
        {
        }

        public string Hostname { get; set; }

        public string Port { get; set; }

        public string Password { get; set; }
    }
}
