using DataStore.Todo.Commands;
using DataStore.Todo.Data;
using DataStore.Todo.Models;
using MediatR;

namespace DataStore.Todo.Handlers
{
    public class InsertTodoHandler : IRequestHandler<InsertTodoCommand, TodoModel>
    {
        private readonly ITodoAccess data;

        public InsertTodoHandler(ITodoAccess data)
        {
            this.data = data;
        }
        public Task<TodoModel> Handle(InsertTodoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.InsertTodo(request.model));
        }
    }
}