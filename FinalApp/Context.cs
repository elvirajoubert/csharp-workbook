using Microsoft.EntityFrameworkCore;

namespace FinalApp
{
    public class FinalAppDBContext : DbContext
    {

        public FinalAppDBContext(DbContextOptions<FinalAppDBContext> options) : base(options)
        {
            Options = options;
        }
        public DbSet<Program.Todo> Todos { get; set; }
        public DbContextOptions<FinalAppDBContext> Options { get; set; }
    }

}



