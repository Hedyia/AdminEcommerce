using System.Threading.Tasks;
using Application.Categories.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class CategoriesController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCategoryCommand command)
        {
            return await Mediator.Send(command);
        } 
    }
}