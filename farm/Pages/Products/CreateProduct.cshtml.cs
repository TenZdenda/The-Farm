using System;
using farm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace farm.Pages.Products
{
    public class CreateProductModel : PageModel
    {

        private ProductCatalog catalog;

        [BindProperty]
        public Product Product { get; set; }

        public CreateProductModel()
        {
            catalog = ProductCatalog.Instance;
        }

        public int validUser;
        public string email;

        public void OnGet()
        {
            VerifyLogin();

            void VerifyLogin()
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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            catalog.AddProduct(Product);

            return RedirectToPage("GetAllProducts");
        }
    }
}
