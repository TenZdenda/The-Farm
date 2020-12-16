using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using farm.Models;

namespace farm.Services
{
    public class UserService : IUserService
    {

        private List<User> users;
        private JsonFileUserService JsonFileUserService;

        public UserService(JsonFileUserService jsonFileUserService)
        {
            JsonFileUserService = jsonFileUserService;
            users = JsonFileUserService.GetJsonUsers();
        }

        public void AddUser(User user)
        {
            user.Password = PasswordHash(user.Email, user.Password);
            users.Add(user);

            JsonFileUserService.SaveJsonUser(users);
        }

        public bool CheckPassword(string email, string password)
        {
            bool loggedIn = false;

            foreach(var v in users)
            {
                if(v.Email == email)
                {
                    string jsonPassword = v.Password;
                    PasswordHasher<string> pw = new PasswordHasher<string>();

                    var verificationResult = pw.VerifyHashedPassword(email, jsonPassword, password);

                    if (verificationResult == PasswordVerificationResult.Success)
                    {
                        loggedIn = true;
                    } else
                    {
                        loggedIn = false;
                    }
                }
            }

            return loggedIn;
        }

        public string PasswordHash(string email, string password)
        {
            PasswordHasher<string> pw = new PasswordHasher<string>();
            string passwordHashed = pw.HashPassword(email, password);
            return passwordHashed;
        }

    }
}
