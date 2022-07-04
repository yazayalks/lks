using System;
using System.Collections.Generic;

#nullable disable

namespace lks.DbContexts
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TypeId { get; set; }
        public byte[] Photo { get; set; }

        public virtual Type Type { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
