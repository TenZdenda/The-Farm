using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using farm.Models;

namespace farm
{
    public class EditProductModel : PageModel
    {

        public int validUser;
        public string email;
        private ProductCatalog catalog;

        [BindProperty]
        public Product product { get; set; }

        public EditProductModel()
        {
            catalog = ProductCatalog.Instance;
        }

        public void OnGet(int id)
        { 
            VerifyLogin();
            product = catalog.GetProduct(id);
        }

        public IActionResult OnPost()
        {

            VerifyLogin();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            catalog.UpdateProduct(product);

            return RedirectToPage("GetAllProducts");
        }

        public void VerifyLogin()
        {
            if (HttpContext.Session.GetInt32("Login") != null)
            {
                validUser = (int)HttpContext.Session.GetInt32("Login");
            }
            else
            {
                validUser = 0;
                RedirectToPage("Login");
            }

            if (HttpContext.Session.GetString("Email") != null)
            {
                email = HttpContext.Session.GetString("Email");
            }
            else
            {
                email = null;
                RedirectToPage("Login");
            }
        }
    }
}
