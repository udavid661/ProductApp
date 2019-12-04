using System;
using System.ComponentModel.DataAnnotations;

namespace Product_Web_App.Models
{
    public class Products
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}