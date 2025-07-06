using MediatR;
using MyConcept.BusinessLogic.Handlers.Shoes.Create.Models;

namespace MyConcept.BusinessLogic.Handlers.Shoes.Create
{
    public record CreateShoesRequest(CreateShoesDto ShoesDto) : IRequest;
}
