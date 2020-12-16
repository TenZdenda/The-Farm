using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using farm.Models;
using farm.Helpers;

namespace farm.Services
{
    public class JsonFileUserService
    {
        string JsonFileName = @"./wwwroot/Data/User.json";

        public List<User> GetJsonUsers()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void SaveJsonUser(List<User> users)
        {
            JsonFileWritter.WriteToJson(users, JsonFileName);
        }
    }
}
