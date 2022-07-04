using System;
using System.Collections.Generic;

#nullable disable

namespace lks.DbContexts
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PageId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Page Page { get; set; }
        public virtual User User { get; set; }
    }
}
