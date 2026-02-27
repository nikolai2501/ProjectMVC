using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Project.Models.TaskItem> TaskItem { get; set; } = default!;
        public DbSet<Project.Models.TaskList> TaskList { get; set; } = default!;
    }
}
