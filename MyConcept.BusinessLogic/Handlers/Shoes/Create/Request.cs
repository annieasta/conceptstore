using MediatR;
using MyConcept.BusinessLogic.Handlers.Shoes.Create.Models;

namespace MyConcept.BusinessLogic.Handlers.Shoes.Create
{
    public class Request(CreateShoesDto shoesDto) : IRequest;
}
