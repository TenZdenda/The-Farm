using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using farm.Models;

namespace farm.Pages.Orders
{
    public class GetAllOrdersModel : PageModel
    {

        private OrderCatalog catalog;

        public Dictionary<int, Order> Orders { get; private set; }

        public int validUser;
        public string email;

        public GetAllOrdersModel()
        {
            catalog = OrderCatalog.Instance;
        }

        public void OnGet()
        {
            VerifyLogin();
            OrderData();

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

            void OrderData()
            {
                Orders = catalog.AllOrders();
            }
        }
    }
}
