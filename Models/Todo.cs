using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAPIv8.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
