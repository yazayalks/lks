using System;
using System.Collections.Generic;

#nullable disable

namespace lks.DbContexts
{
    public partial class Page
    {
        public Page()
        {
            Comments = new HashSet<Comment>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
