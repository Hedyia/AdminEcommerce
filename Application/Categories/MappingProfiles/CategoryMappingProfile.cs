using Application.Categories.Commands;
using AutoMapper;
using Core.Entities;

namespace Application.Categories.MappingProfiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
        }
    }
}