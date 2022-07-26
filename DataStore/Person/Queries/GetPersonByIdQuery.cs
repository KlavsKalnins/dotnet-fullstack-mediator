using DataStore.Person.Models;
using MediatR;

namespace DataStore.Person.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}