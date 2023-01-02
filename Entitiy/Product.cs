using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entitiy
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public int? CategoryId { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
