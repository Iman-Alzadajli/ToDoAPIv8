namespace ToDoAPIv8.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Todo> todos { get; set; } = new List<Todo>();
    }
}
