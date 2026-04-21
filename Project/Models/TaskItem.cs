using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public int TaskListId { get; set; }
        public TaskList TaskList { get; set; }
    }
}
