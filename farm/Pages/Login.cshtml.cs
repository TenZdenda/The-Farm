using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

using farm.Services;
using farm.Models;

namespace farm
{
    public class LoginModel : PageModel
    {
        IUserService userService;

        public LoginModel(IUserService service)
        {
            userService = service;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return CheckLogin();
        }

        IActionResult CheckLogin()
        {
            string password, email;
            email = Request.Form["Email"];
            password = Request.Form["Password"];

            bool validUser = userService.CheckPassword(email, password);

            if (validUser == true)
            {
                HttpContext.Session.SetInt32("Login", 1);
                HttpContext.Session.SetString("Email", email);
                return RedirectToPage("Dashboard");
            }
            else
            {
                HttpContext.Session.SetInt32("Login", 0);
                HttpContext.Session.SetString("Email", "");
                return RedirectToPage("Login");
            }
        }
    }
}
