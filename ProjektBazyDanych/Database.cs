using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    class Database : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=127.0.0.1;Database=airport_database;Uid=root;Pwd=root;");
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Passengers> Passengers { get; set; }

    }
}
