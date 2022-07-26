using DataStore.Person.Data;
using DataStore.Person.Models;
using DataStore.Person.Queries;
using MediatR;

namespace DataStore.Person.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IPersonAccess _data;
        public GetPersonListHandler(IPersonAccess data)
        {
            _data = data;
        }
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPerson());
            //throw new NotImplementedException();
        }
    }
}