using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entitiy
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Sum { get; set; }
        public int? UserId { get; set; }
        [JsonIgnore]
        public virtual UserTable? User { get; set; }
       
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
