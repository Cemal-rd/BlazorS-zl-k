using BlazorSozluk.Api.Application.Interfaces;
using Blazorsozluk.Api.Models;
using Blazorsozluk.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Infrastructure.Persistence.Repositories
{
    public class EntryCommentRepository : GenericRepository<EntryComment>, IEntryCommentRepository
    {
        public EntryCommentRepository(BlazorSozlukContext dbContext) : base(dbContext)
        {
        }
    }
}
