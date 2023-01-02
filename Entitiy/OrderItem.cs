using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entitiy
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int? CarId { get; set; }
        public int? OrdersId { get; set; }
        public int? Quantity { get; set; }
        [JsonIgnore]
        public virtual Product? Car { get; set; }
        [JsonIgnore]
        public virtual Order? Orders { get; set; }
    }
}
