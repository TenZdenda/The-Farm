using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using farm.Models;

namespace farm.Helpers
{
    public class JsonFileReader
    {
        public static List<User> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<List<User>>(jsonString);
        }
    }
}
