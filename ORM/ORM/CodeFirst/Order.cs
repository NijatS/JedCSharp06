using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.CodeFirst
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipAddress { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
