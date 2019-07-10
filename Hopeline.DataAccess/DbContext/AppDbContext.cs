using Hopeline.DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hopeline.DataAccess.DatabaseContext
{
    public class AppDbContext : IdentityDbContext
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
        public DbSet<HopelineUser> hopelineUsers { get; set; }

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
            modelBuilder.Entity<HopelineUser>();
        }
    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("server=desktop-guuo2i0\\sqlexpress;database=A_HOPELINE_DEV;Trusted_Connection=true");
            return new AppDbContext(builder.Options);
        }
    }
}
