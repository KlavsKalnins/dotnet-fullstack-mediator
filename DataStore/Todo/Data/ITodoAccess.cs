using DataStore.Todo.Models;

namespace DataStore.Todo.Data
{
    public interface ITodoAccess
    {
        List<TodoModel> GetTodo();
        TodoModel InsertTodo(TodoModel model);
        TodoModel DeleteTodo(int id);
    }
}