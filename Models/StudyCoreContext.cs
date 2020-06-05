using Microsoft.EntityFrameworkCore;

namespace StudyScore.Models
{
    public class StudyCoreContext : DbContext
    {
        public StudyCoreContext(DbContextOptions<StudyCoreContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}