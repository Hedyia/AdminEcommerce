using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Auth;
using Core.Errors;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IApplicationDbContext _context;
        public AuthRepository(IApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IJwtGenerator jwtGenerator)
        {
            _context = context;
            _jwtGenerator = jwtGenerator;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<User> SignIn(LoginAuth login)
        {
            var user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
                throw new RestException(HttpStatusCode.Unauthorized);

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, login.Password, false);
            if (result.Succeeded)
            {
                //generate token
                return new User
                {
                    DisplayName = user.DisplayName,
                    Token = _jwtGenerator.CreateToken(user),
                    Username = user.UserName,
                };
            }
            throw new RestException(HttpStatusCode.Unauthorized);
        }

        public async Task<User> SignUp(RegisterAuth register)
        {
            if (await _context.Users.Where(x => x.Email == register.Email).AnyAsync())
                throw new RestException(HttpStatusCode.BadRequest, new { Email = "Email already exists" });

            if (await _context.Users.Where(x => x.UserName == register.Username).AnyAsync())
                throw new RestException(HttpStatusCode.BadRequest, new { Username = "Username already exists" });

            var user = new ApplicationUser
            {
                DisplayName = register.DisplayName,
                Email = register.Email,
                UserName = register.Username
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                return new User
                {
                    DisplayName = user.DisplayName,
                    Token = _jwtGenerator.CreateToken(user),
                    Username = user.UserName,
                };
            }

            throw new Exception("Problem creating user");
        }
    }
}