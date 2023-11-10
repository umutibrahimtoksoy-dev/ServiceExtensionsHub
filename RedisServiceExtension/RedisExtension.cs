using Microsoft.Extensions.DependencyInjection;

namespace RedisServiceExtension
{
    public static class RedisExtension
    {
        public static IServiceCollection UseRedis(this IServiceCollection services)
        {
            services.AddStackExchangeRedisCache(options =>
            options.Configuration = "localhost:1881" //TO DO 
            );

            return services;
        }
    }
}
