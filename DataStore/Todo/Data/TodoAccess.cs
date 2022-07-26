using DataStore.Todo.Models;

namespace DataStore.Todo.Data
{
    // Add you EF core here
    // maybe create a generic dbContext for all DataAccess research
    public class TodoAccess : ITodoAccess
    {
        private List<TodoModel> model = new();

        public TodoAccess()
        {
            model.Add(new TodoModel() { Id = 1, Title = "Create this API UI", TimeCreated = default, TimeCompleted = null });
        }
        public List<TodoModel> GetTodo()
        {
            return model;
        }
        public TodoModel InsertTodo(TodoModel value)
        {
            value.Id = model.Max(x => x.Id) + 1;
            model.Add(value);
            return value;
        }

        public TodoModel DeleteTodo(int id)
        {
            var result = model.Single(c => c.Id == id);
            model.Remove(result);
            return result;
        }
    }
}