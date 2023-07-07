using System;
using System.Text.Json;
namespace Weather.Services;
public class DeserializeService
{
    public static T Deserialize<T>(string? json)
    {
        if (json != null)
        {
            T? res = JsonSerializer.Deserialize<T>(json);

            if (res != null)
            {
                return res;
            }
        }
        throw new NullReferenceException();
    }
}