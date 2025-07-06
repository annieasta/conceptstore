using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyConcept.BusinessLogic.Handlers.Shoes.Create;
using MyConcept.BusinessLogic.Handlers.Shoes.Create.Models;

namespace MyConcept.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController(IMediator Mediator) : ControllerBase
    {
        [HttpPost]
        public async Task Create(CreateShoesDto shoes)
        {
            await Mediator.Send(new CreateShoesRequest(shoes));
        }
    }
}
