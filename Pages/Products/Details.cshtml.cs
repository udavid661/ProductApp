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
    public class DetailsModel : PageModel
    {
        private readonly Product_Web_App.Data.ProductContext _context;

        public DetailsModel(Product_Web_App.Data.ProductContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
