using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using farm.Models;

namespace farm.Pages
{
    public class ProductsModel : PageModel
    {

        private ProductCatalog catalog;

        public Dictionary<int, Product> Products { get; private set; }

        public ProductsModel()
        {
            catalog = ProductCatalog.Instance;
        }

        public void OnGet()
        {
            Products = catalog.AllProducts();
        }
    }
}
