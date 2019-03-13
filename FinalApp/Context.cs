using System;
using System.Collections.Generic;

using static FinalApp.Program;

namespace FinalApp
{
    public class Context : DbContext
    {
        internal IEnumerable<Todo> myList;
        private DbSet<Todo> _myList;

        public DbSet<Todo> MyList { get => _myList; set => _myList = value; }

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
