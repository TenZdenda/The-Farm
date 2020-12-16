using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using farm.Services;
using farm.Models;

namespace farm.Pages
{
    public class RegisterModel : PageModel
    {

        IUserService userService;

        public RegisterModel(IUserService service)
        {
            userService = service;
        }

        public void OnGet()
        {}

        public IActionResult OnPost()
        {
            string name = Request.Form["Name"];
            string email = Request.Form["Email"];
            string password = Request.Form["Password"];

            User user = new User() { Name = name, Email = email, Password = password };

            userService.AddUser(user);

            return Redirect("Login");
        }
    }
}
