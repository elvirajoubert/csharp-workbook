using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}