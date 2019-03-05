using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarwashLib
{
    public class JsonHelper
    {
        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string SerializeJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
