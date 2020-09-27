using System.Threading;
using System.Threading.Tasks;
using Application.Categories.Commands;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.Categories.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Categories.AddAsync(_mapper.Map<Category>(request), cancellationToken);
            return result;
        }
    }
}