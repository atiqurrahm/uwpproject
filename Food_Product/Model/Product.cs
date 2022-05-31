using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Product.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public double Price { get; set; }
        public DateTime Manufacture { get; set; }
        public DateTime Expiare { get; set; }
        public string CompanyName { get; set; }
        public string Category { get; set; }
        public bool isContinuing { get; set; } = false;
        public string Picture { get; set; }
        public string ManufacrureDate { get => this.Manufacture.ToString("yyyy-MMM-dd"); }
        public string ExpiareDate { get => this.Expiare.ToString("yyyy-MMM-dd"); }
    }
}
