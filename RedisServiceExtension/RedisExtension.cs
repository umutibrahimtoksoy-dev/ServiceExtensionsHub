using Microsoft.Extensions.DependencyInjection;
using RedisServiceExtension.Services;

namespace RedisServiceExtension
{
    public static class RedisExtension
    {
        public static IServiceCollection UseRedis(this IServiceCollection services)
        {
            services.AddScoped<IRedisService, RedisService>();

            services.AddStackExchangeRedisCache(options =>
            options.Configuration = "localhost:1881" //TO DO 
            );

            return services;
        }
    }
}
