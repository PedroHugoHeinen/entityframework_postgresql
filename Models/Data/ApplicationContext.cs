using entityframework_postgresql.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace entityframework_postgresql.Models.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions)
            : base(contextOptions)
        {
        }

        public DbSet<People> People { get; set; }
    }
}
