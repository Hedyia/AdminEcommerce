using System.Threading;
using System.Threading.Tasks;
using Application.Users.Rigster.Commands;
using AutoMapper;
using Core.Entities;
using Core.Entities.Auth;
using Core.Interfaces;
using MediatR;

namespace Application.Users.Rigster.Handlers
{
    public class CreateRegisterCommandHandler : IRequestHandler<CreateRegisterCommand, User>
    {
         private readonly IAuthRepository _auth;
        private readonly IMapper _mapper;
        public CreateRegisterCommandHandler (IAuthRepository auth, IMapper mapper) {
            _mapper = mapper;
            _auth = auth;

        }
        public async Task<User> Handle(CreateRegisterCommand request, CancellationToken cancellationToken)
        {
            var result = await _auth.SignUp(_mapper.Map<RegisterAuth>(request));
            return result;
        }
    }
}