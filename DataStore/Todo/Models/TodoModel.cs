namespace DataStore.Todo.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime? TimeCompleted { get; set; }

        internal int Max(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}