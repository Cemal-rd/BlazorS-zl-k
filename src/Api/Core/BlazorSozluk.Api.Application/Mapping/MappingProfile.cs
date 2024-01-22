using AutoMapper;
using Blazorsozlık.common.Models.Queries;
using Blazorsozlık.common.Models.RequestModels;
using Blazorsozluk.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, LoginUserViewModel>()
                .ReverseMap();
            CreateMap<User,CreateUserCommand>()
                .ReverseMap();
        }
    }
}
