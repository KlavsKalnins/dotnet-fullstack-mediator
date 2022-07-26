using DataStore.Person.Commands;
using DataStore.Person.Data;
using DataStore.Person.Models;
using MediatR;

namespace DataStore.Person.Handlers
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, PersonModel>
    {
        private readonly IPersonAccess data;

        public DeletePersonHandler(IPersonAccess data)
        {
            this.data = data;
        }

        public async Task<PersonModel> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(data.DeletePerson(request.Id));
        }
    }
}