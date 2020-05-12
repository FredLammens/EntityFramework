using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Data
{
    class BoekContext : DbContext
    {
        public DbSet<Boek> Boeken { get; set; } // getters en setters belangrijk voor tabellen aan te maken
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { // instellen welke databank
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OF28PIK\SQLEXPRESS;Initial Catalog=boekDB;Integrated Security=True");
        }
    }
}
