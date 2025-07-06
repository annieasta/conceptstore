using AutoMapper;
using MediatR;
using MyConcept.Data;
using MyConcept.Data.Entities;

namespace MyConcept.BusinessLogic.Handlers.Shoes.Create
{
    internal class CreateShoesHandler(MyConceptContext Context, IMapper Mapper) : IRequestHandler<CreateShoesRequest>
    {
        public async Task Handle(CreateShoesRequest request, CancellationToken cancellationToken)
        {
            var newShoe = Mapper.Map<ShoeEntity>(request.ShoesDto);

            Context.Shoes.Add(newShoe);
            await Context.SaveChangesAsync(cancellationToken);
        }
    }
}
