using System;
using StackExchange.Redis;

namespace Recommendations.Connections
{
    public class RedisManager
    {
        private static ConnectionMultiplexer muxer;

        public static void InitializeManager(RedisConnection connectionConfiguration)
        {
            if (muxer != null)
            {
                throw new InvalidOperationException("Connection multiplexer has already been initialized");
            }

            muxer = ConnectionMultiplexer.Connect($"{connectionConfiguration.Hostname}:{connectionConfiguration.Port},password={connectionConfiguration.Password}");
        }

        public static IDatabase GetConnection()
        {
            var connection = muxer.GetDatabase();
            return connection;
        } 
    }
}
