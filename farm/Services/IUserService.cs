using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using farm.Models;

namespace farm.Services
{
    public interface IUserService
    {
        public void AddUser(User user);
        bool CheckPassword(string email, string password);
    }
}
