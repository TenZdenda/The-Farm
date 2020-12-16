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
    public class GetAllProductsModel : PageModel
    {

        private ProductCatalog catalog;
        public int validUser;
        public string email;

        public GetAllProductsModel()
        {
            catalog = ProductCatalog.Instance;
        }

        public Dictionary<int, Product> Products { get; private set; }

        public void OnGet()
        {
            VerifyLogin();
            ProductData();

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

            void ProductData()
            {
                Products = catalog.AllProducts();
            }
        }
    }
}
