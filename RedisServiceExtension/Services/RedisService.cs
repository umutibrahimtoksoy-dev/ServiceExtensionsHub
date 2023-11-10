using Microsoft.Extensions.Caching.Distributed;

namespace RedisServiceExtension.Services
{
    public class RedisService : IRedisService
    {
        private readonly IDistributedCache _distributedCache;

        public RedisService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task<string> Get(string key)
        {
            var value = await _distributedCache.GetStringAsync(key);
            if (string.IsNullOrEmpty(value))
            {
                return "Key not found";
            }

            return value;
        }

        public async Task Remove(string key)
        {
            await _distributedCache.RemoveAsync(key);
        }

        public async Task SetString(string key, string value)
        {
            await _distributedCache.SetStringAsync(key, value);
        }

        public async Task SetString(List<KeyValuePair<string, string>> keyValuePairList)
        {
            foreach (KeyValuePair<string, string> keyValuePair in keyValuePairList)
            {
                await _distributedCache.SetStringAsync(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
