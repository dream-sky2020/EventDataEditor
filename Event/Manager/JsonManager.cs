using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;

namespace Event.Manager
{
    internal class JsonManager
    {
        public static string LoadObjectToJsonString<T>(T t_object) 
        {
            var options=new JsonSerializerOptions();
            options.WriteIndented = true;
            options.Encoder= System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return JsonSerializer.Serialize<T>(t_object, options);
        }
        public static T LoadJsonStringToObject<T>(string t_jsonString)
        {
            return JsonSerializer.Deserialize<T>(t_jsonString);
        }
    }
}
