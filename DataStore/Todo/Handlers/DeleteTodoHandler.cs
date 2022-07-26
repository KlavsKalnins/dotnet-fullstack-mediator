using DataStore.Todo.Commands;
using DataStore.Todo.Data;
using DataStore.Todo.Models;
using MediatR;

namespace DataStore.Todo.Handlers
{
    public class DeleteTodoHandler : IRequestHandler<DeleteTodoCommand, TodoModel>
    {
        private readonly ITodoAccess data;

        public DeleteTodoHandler(ITodoAccess data)
        {
            this.data = data;
        }

        public async Task<TodoModel> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(data.DeleteTodo(request.Id));
        }
    }
}