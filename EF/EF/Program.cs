using Microsoft.EntityFrameworkCore;
using System;

namespace EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DbContextOptionsBuilder<BlogDbContext> builder = new DbContextOptionsBuilder<BlogDbContext>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BlogDb;Trusted_Connection=true");
            DbContextOptions<BlogDbContext> opts = builder.Options;
            BlogDbContext context = new BlogDbContext(opts);

            context.Database.EnsureCreated();

            Blog firstEntry = new Blog
            {
                Title = "First!",
                CreateDate = DateTime.Now,
                Content = "bump"
            };

            context.Blogs.Add(firstEntry);

            Console.WriteLine($"Value of Id: {firstEntry.Id}");

            context.SaveChanges();

            Console.WriteLine($"Value of Id after save: {firstEntry.Id}");
            foreach (var entry in context.Blogs)
            {
                Console.WriteLine(entry.Id + "->" + entry.Title + ": " + entry.Content);
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}