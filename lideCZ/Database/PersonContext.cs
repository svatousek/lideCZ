using lideCZ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lideCZ.Database
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //soubor nasi databaze
            optionsBuilder.UseSqlite("Data Source=seznamlidi.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //dataSeed
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Jan", LastName = "Novák", Age = 30 },
                new Person { Id = 2, FirstName = "Petr", LastName = "Svoboda", Age = 30 }
                );
        }
    }
}
