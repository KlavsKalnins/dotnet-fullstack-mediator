using DataStore.Todo.Models;
using MediatR;

namespace DataStore.Todo.Commands
{
    public record InsertTodoCommand(TodoModel model) : IRequest<TodoModel>;
}