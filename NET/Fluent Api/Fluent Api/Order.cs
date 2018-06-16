using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Api
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public ICollection<Product> Products { get; set; }
        public Order() { }
    }
}
