using Kino.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.Domain.DomainModels
{
    public class Order: BaseEntity
    {
        public string UserId { get; set; }
        public KinoApplicationUser User { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }

    }
}
