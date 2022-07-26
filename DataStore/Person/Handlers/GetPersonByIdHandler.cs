using DataStore.Person.Models;
using DataStore.Person.Queries;
using MediatR;

namespace DataStore.Person.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IMediator mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            // do a lookup db instead
            var results = await mediator.Send(new GetPersonListQuery());

            var output = results.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}