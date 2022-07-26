using DataStore.Person.Commands;
using DataStore.Person.Data;
using DataStore.Person.Models;
using MediatR;

namespace DataStore.Person.Handlers
{

    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IPersonAccess data;

        public InsertPersonHandler(IPersonAccess data)
        {
            this.data = data;
        }
        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.InsertPerson(request.Name));
        }
    }
}