using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TaskManagerPro.Models;

namespace TaskManagerPro.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // constructor for ApplicationDbContext, passing configuration options to the base class DbContext.
        public DbSet<TaskItem> Tasks { get; set; }
        //Now your context is aware of the Tasks table.

    }

    public class ApplicationUser: IdentityUser
    {
    }
}
