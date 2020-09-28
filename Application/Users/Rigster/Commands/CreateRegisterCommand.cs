using Core.Entities;
using MediatR;

namespace Application.Users.Rigster.Commands
{
    public class CreateRegisterCommand : IRequest<User>
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}