using MediatR;

namespace Application.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string DefaultImage { get; set; }
    }
}