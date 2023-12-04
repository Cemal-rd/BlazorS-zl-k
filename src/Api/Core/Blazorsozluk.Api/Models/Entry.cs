﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Api.Models
{
    public class Entry:BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public Guid CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual ICollection<EntryComment> EntryComments { get; set; }
        public virtual ICollection<EntryVotes> EntryVotes { get; set; }
        public virtual ICollection<EntryFavorite> EntryFavorite { get; set; }



    }
}
