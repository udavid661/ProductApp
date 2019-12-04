using Microsoft.EntityFrameworkCore;
using Product_Web_App.Models;
namespace Product_Web_App.Data
{
    public class ProductContext: DbContext
    {
      public ProductContext(DbContextOptions<ProductContext>options):base(options) {}
      public DbSet<Models.Products>Product { get; set; }
      
    }
}