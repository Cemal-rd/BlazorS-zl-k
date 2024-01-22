using AutoMapper;
using Blazorsozlık.common.Infrastructure.Exceptions;
using Blazorsozlık.common.Models.RequestModels;
using BlazorSozluk.Api.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Application.Features.Commands.User.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public CreateUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
           var existuser=await userRepository.GetSingleAsync(i=>i.EmailAddress== request.EmailAddress);
            if (existuser is not null)
                throw new DatabaseValidationException("user already exists");
            var dbUser = mapper.Map<Blazorsozluk.Api.Models.User>(request);
            var rows=await userRepository.AddAsync(dbUser);
            

        }
    }
}
