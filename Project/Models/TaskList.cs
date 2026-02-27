using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TaskList
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public List<TaskItem> Tasks { get; set; } = new();
    }
}
