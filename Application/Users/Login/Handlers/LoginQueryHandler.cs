using System.Threading;
using System.Threading.Tasks;
using Application.Users.Login.Queries;
using AutoMapper;
using Core.Entities;
using Core.Entities.Auth;
using Core.Interfaces;
using MediatR;

namespace Application.Users.Login.Handlers {
    public class LoginQueryHandler : IRequestHandler<LoginQuery, User> {
        private readonly IAuthRepository _auth;
        private readonly IMapper _mapper;
        public LoginQueryHandler (IAuthRepository auth, IMapper mapper) {
            _mapper = mapper;
            _auth = auth;

        }
        public async Task<User> Handle (LoginQuery request, CancellationToken cancellationToken) {
            var result = await _auth.SignIn (_mapper.Map<LoginAuth>(request));
            return result;
        }
    }
}