using DataStore.Todo.Data;
using DataStore.Todo.Models;
using DataStore.Todo.Queries;
using MediatR;

namespace DataStore.Todo.Handlers
{
    public class GetTodoListHandler : IRequestHandler<GetTodoListQuery, List<TodoModel>>
    {
        private readonly ITodoAccess _data;
        public GetTodoListHandler(ITodoAccess data)
        {
            _data = data;
        }
        public Task<List<TodoModel>> Handle(GetTodoListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetTodo());
        }
    }
}