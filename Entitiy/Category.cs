using System;
using System.Collections.Generic;

namespace Entitiy
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Company { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
