using System.Threading.Tasks;
using Application.Users.Login.Queries;
using Application.Users.Rigster.Commands;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AuthController : ApiController
    {
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(LoginQuery query)
        {
            return await Mediator.Send(query);
        }

         [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(CreateRegisterCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}