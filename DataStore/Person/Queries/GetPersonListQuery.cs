using DataStore.Person.Models;
using MediatR;

namespace DataStore.Person.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}