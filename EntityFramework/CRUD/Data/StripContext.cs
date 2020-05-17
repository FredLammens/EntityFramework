using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data
{
    class StripContext : DbContext
    {
        public DbSet<Strip> Strips { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Reeks> Reeksen { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OF28PIK\SQLEXPRESS;Initial Catalog=StripDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuteurStrip>().HasKey(x => new { x.StripID, x.AuteurID });
        }
    }
}
