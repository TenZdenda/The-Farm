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
    public class DeleteOrderModel : PageModel
    {

        public int validUser;
        public string email;

        private OrderCatalog catalog;

        [BindProperty]
        public Order Order { get; set; }

        public DeleteOrderModel()
        {
            catalog = OrderCatalog.Instance;
        }

        public void OnGet(int id)
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

            Order = catalog.GetOrder(id);
        }

        public IActionResult OnPost()
        {
            catalog.DeleteOrder(Order);
            return RedirectToPage("GetAllOrders");
        }
    }
}
