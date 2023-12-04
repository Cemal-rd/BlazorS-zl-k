using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Api.Models
{
   public class EntryFavorite:BaseEntity
    {
        public Guid EntryId { get; set; }
        public Guid CreatedById { get; set; }
    }
}
