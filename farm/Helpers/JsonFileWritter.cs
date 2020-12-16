using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

using farm.Models;

namespace farm.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(List<User> users, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(users);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
