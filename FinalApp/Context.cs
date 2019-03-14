using Microsoft.EntityFrameworkCore;
using static FinalApp.Program;

namespace FinalApp
{
    public class FinalAppDBContext : DbContext
    {

        public FinalAppDBContext(DbContextOptions<FinalAppDBContext> options) : base(options)
        {
            Options = options;
        }
        public DbSet<Todo> Todos { get; set; }
        public DbContextOptions<FinalAppDBContext> Options { get; }
    }

}



