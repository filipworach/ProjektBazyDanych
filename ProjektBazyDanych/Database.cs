using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=127.0.0.1;Database=airport_database;Uid=root;Pwd=root;");
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Passengers> Passengers { get; set; }
        public DbSet<Reservations> Reservations{get;set;}
        public DbSet<Flights> Flights{get;set;}
        public DbSet<Pilots> Pilots {get;set;}
        public DbSet<Connections> Connections {get;set;}
        public DbSet<Cities> Cities {get;set;}
        public DbSet<Planes> Planes {get;set;}

}
}
