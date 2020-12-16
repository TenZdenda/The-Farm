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
    public class DeleteProductModel : PageModel
    {

        public int validUser;
        public string email;

        private ProductCatalog catalog;

        [BindProperty]
        public Product Product { get; set; }

        public DeleteProductModel()
        {
            catalog = ProductCatalog.Instance;
        }

        public IActionResult OnGet(int id)
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

            Product = catalog.GetProduct(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeleteProduct(Product);
            return RedirectToPage("GetAllProducts");
        }
    }
}
