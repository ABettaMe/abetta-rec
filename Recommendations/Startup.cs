using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Recommendations.Connections;
using NReJSON;
using Recommendations.Events;
using StackExchange.Redis;

namespace Recommendations
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            RedisConnection redisConfiguration = ReadRedisConfiguration();
            RedisManager.InitializeManager(redisConfiguration);

            ExampleForGetSet();

            var subscriber = RedisManager.GetSubscriber();
            MetricUpdateSubscriber.Register(subscriber);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Recommendations", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Recommendations v1"));
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ExampleForGetSet()
        {
            var experiment = new Experiment()
            {
                Id = new Guid().ToString(),
                Name = "A new experiment for me"
            };

            var database = RedisManager.GetConnection();
            var jsonWrite = database.JsonSet("Experiments:antonis", experiment);
            var jsonExample2 = database.JsonGet<Experiment>("Experiments:antonis");
        }

        private RedisConnection ReadRedisConfiguration()
        {
            var hostname = Configuration.GetValue(typeof(string), "Redis:Hostname") as string;
            var port = Configuration.GetValue(typeof(string), "Redis:Port") as string;
            var password = Configuration.GetValue(typeof(string), "Redis:Password") as string;
            var redisConfiguration = new RedisConnection()
            {
                Hostname = hostname,
                Port = port,
                Password = password
            };
            return redisConfiguration;
        }
    }
}
