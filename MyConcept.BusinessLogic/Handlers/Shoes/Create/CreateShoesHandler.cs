using MediatR;

namespace MyConcept.BusinessLogic.Handlers.Shoes.Create
{
    internal class CreateShoesHandler : IRequestHandler<CreateShoesRequest>
    {
        public Task Handle(CreateShoesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
