using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public KinoApplicationUser User { get; set; }
        public ICollection<ProductInOrder> ProductInOrders { get; set; }
    }
}
