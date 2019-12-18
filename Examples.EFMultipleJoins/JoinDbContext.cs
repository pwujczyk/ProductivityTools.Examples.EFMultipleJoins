using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.EFMultipleJoins
{
    class JoinDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\sql2017;Database=JonExample1;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskTomato>().HasKey(x => new { x.TaskId, x.TomatoId });
            modelBuilder.Entity<TaskTomato>().HasOne(x => x.Tomato).WithMany(x =>x.TaskTomato).HasForeignKey(x=>x.TaskId);
            modelBuilder.Entity<TaskTomato>().HasOne(x => x.Task).WithMany(x => x.TaskTomato).HasForeignKey(x => x.TomatoId);
                base.OnModelCreating(modelBuilder);

        }

        public DbSet<Task> Task { get; set; }
        public DbSet<Tomato> Tomato { get; set; }
    }
}
