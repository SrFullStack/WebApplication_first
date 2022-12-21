using System;
using System.Collections.Generic;

namespace Entitiy
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int? CarId { get; set; }
        public int? OrdersId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product? Car { get; set; }
        public virtual Order? Orders { get; set; }
    }
}
