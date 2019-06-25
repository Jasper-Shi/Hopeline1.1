using Hopeline.DataAccess.Entities;
using Hopeline.DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.DataAccess.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext()
        //{

        //}
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Resource> resources { get; set; }
        public DbSet<Community> communities { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Resource_Category> resource_categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Resource>()
                .HasOne(p => p.resource_category)
                .WithMany(b => b.resources)
                .HasForeignKey(p => p.resource_categoryId)
                .HasConstraintName("Foreign_key_resource_category");
            modelBuilder.Entity<Community>();
            modelBuilder.Entity<Topic>();
            modelBuilder.Entity<Resource_Category>();
        }
    }
}
