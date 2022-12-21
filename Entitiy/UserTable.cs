﻿using System;
using System.Collections.Generic;

namespace Entitiy
{
    public partial class UserTable
    {
        public UserTable()
        {
            Orders = new HashSet<Order>();
        }

        public int Userid { get; set; }
        public string? Email { get; set; }
        public string? Nameuser { get; set; }
        public int? Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
