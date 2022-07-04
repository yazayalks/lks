using System;
using System.Collections.Generic;

#nullable disable

namespace lks.DbContexts
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int PageId { get; set; }
        public int UserId { get; set; }

        public virtual Page Page { get; set; }
        public virtual User User { get; set; }
    }
}
