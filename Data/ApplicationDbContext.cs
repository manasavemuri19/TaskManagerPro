using Microsoft.EntityFrameworkCore;
using TaskManagerPro.Models;

namespace TaskManagerPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // constructor for ApplicationDbContext, passing configuration options to the base class DbContext.
        public DbSet<TaskItem> Tasks { get; set; }
        //Now your context is aware of the Tasks table.



    }
}
