using DataStore.Todo.Models;
using MediatR;

namespace DataStore.Todo.Queries
{
    public record GetTodoListQuery() : IRequest<List<TodoModel>>;
}