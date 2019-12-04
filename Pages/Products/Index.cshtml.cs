using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Product_Web_App.Data;
using Product_Web_App.Models;

namespace Product_Web_App.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly Product_Web_App.Data.ProductContext _context;

        public IndexModel(Product_Web_App.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Product.ToListAsync();
        }
    }
}
