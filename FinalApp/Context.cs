using System;
using System.Collections.Generic;
using static FinalApp.Program;

namespace FinalApp
{
    public class Context : DbContext
    {
        public DbSet<Todo> MyList { get; set; }
        public IEnumerable<Todo> myList { get; internal set; }

        protected
        override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./FinalApp.db");
        }

        internal void myListRemove(Todo removeItem)
        {
            throw new NotImplementedException();
        }
    }


}
