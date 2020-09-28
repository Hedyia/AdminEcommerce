using Core.Entities;
using MediatR;

namespace Application.Users.Login.Queries
{
    public class LoginQuery : IRequest<User>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}