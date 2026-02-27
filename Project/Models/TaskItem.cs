using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public DateTime DueDate { get; set; }

        public required string Description { get; set; }

        public int TaskListId { get; set; }
        public required TaskList TaskList { get; set; }
    }
}
