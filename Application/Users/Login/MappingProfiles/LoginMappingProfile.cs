using Application.Users.Login.Queries;
using AutoMapper;
using Core.Entities.Auth;

namespace Application.Users.Login.MappingProfiles
{
    public class LoginMappingProfile : Profile
    {
        public LoginMappingProfile()
        {
            CreateMap<LoginQuery, LoginAuth>();
        }
    }
}