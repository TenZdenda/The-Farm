using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace farm.Pages
{
    public class DashboardModel : PageModel
    {

        private ProductCatalog catalog;
        private OrderCatalog ocatalog;

        public int validUser;
        public string email;

        public int ProductCount;
        public int OrderCount;
        public int Money;

        public DashboardModel()
        {
            catalog = ProductCatalog.Instance;
            ocatalog = OrderCatalog.Instance;
        }

        public void OnGet()
        {
            VerifyLogin();

            ProductCount = catalog.CountProduct();
            OrderCount = ocatalog.OrderCount();
            Money = ocatalog.Money();

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
    }
}
