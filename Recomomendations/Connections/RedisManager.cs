using NReJSON;
using StackExchange.Redis;
using System;
using System.Text.Json;

namespace Recommendations.Connections
{
    public sealed class RedisJsonSerializer : ISerializerProxy
    {
        public TResult Deserialize<TResult>(RedisResult serializedValue) =>
            JsonSerializer.Deserialize<TResult>(serializedValue.ToString());

        public string Serialize<TObjectType>(TObjectType obj) =>
            JsonSerializer.Serialize(obj);
    }

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
            NReJSONSerializer.SerializerProxy = new RedisJsonSerializer();
        }

        public static IDatabase GetConnection()
        {
            var connection = muxer.GetDatabase();
            return connection;
        }

        public static ISubscriber GetSubscriber()
        {
            var connection = muxer.GetSubscriber();
            return connection;
        }
    }
}
