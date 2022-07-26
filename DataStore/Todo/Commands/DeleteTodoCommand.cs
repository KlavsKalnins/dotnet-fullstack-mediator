using DataStore.Todo.Models;
using MediatR;

namespace DataStore.Todo.Commands
{
    public record DeleteTodoCommand(int Id) : IRequest<TodoModel>;
}