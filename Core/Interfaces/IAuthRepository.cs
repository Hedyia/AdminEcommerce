using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Auth;

namespace Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> SignIn(LoginAuth login);
        Task<User> SignUp(RegisterAuth register);

    }
}