using Application.Users.Rigster.Commands;
using AutoMapper;
using Core.Entities.Auth;

namespace Application.Users.Rigster.MappingProfiles
{
    public class RegisterMappingProfile : Profile
    {
        public RegisterMappingProfile()
        {
            CreateMap<CreateRegisterCommand, RegisterAuth>();
        }
    }
}