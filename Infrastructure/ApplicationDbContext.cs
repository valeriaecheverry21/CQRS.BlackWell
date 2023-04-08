using CQRS.BlackWell.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRS.BlackWell.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }
    }
}
