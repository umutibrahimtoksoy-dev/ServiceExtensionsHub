namespace RedisServiceExtension.Services
{
    public interface IRedisService
    {
        Task SetString(string key, string value);
        Task SetString(List<KeyValuePair<string, string>> keyValuePairList);
        Task<string> Get(string key);
        Task Remove(string key);
    }
}
