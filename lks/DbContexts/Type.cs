﻿using System;
using System.Collections.Generic;

#nullable disable

namespace lks.DbContexts
{
    public partial class Type
    {
        public Type()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Type1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
