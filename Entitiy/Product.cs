using System;
using System.Collections.Generic;

namespace Entitiy
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string? Color { get; set; }
        public int? Year { get; set; }
        public int? CompanyId { get; set; }
        public int? Size { get; set; }
        public int? Price { get; set; }
        public string? Image { get; set; }

        public virtual Category? Company { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
