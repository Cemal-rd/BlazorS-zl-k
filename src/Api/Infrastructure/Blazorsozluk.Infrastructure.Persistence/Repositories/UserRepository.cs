using Blazorsozluk.Api.Models;
using Blazorsozluk.Infrastructure.Persistence.Context;
using BlazorSozluk.Api.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BlazorSozlukContext dbContext) : base(dbContext)
        {

        }
    }
}
