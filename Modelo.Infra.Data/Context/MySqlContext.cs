using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("server=127.0.0.1;password=test;port=3306;database=Modelo;user=root;password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
