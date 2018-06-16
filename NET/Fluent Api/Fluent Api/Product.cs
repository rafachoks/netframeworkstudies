using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Api
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int CostPerUnit { get; set; }
        public int NumerInStock { get; set; }
        public ICollection<Order> Orders { get; set; }
        public  Product() { }
    }
}
