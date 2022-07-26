using DataStore.Person.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Person.Commands
{
    public record InsertPersonCommand(string Name) : IRequest<PersonModel>;
}
