using DataStore.Person.Models;
using MediatR;

namespace DataStore.Person.Commands
{
    public record DeletePersonCommand(int Id) : IRequest<PersonModel>;

}