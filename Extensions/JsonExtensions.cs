using Newtonsoft.Json;

namespace Scripture.Api.Extensions;

public static class JsonExtensions
{
    public static T Deserialize<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
    public static string Serialize(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

}
