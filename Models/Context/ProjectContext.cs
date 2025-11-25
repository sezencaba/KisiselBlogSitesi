using Microsoft.EntityFrameworkCore;
using SezenElifCaba_BlogSitesi.Models.Entities;

namespace SezenElifCaba_BlogSitesi.Models.Context
{
    public class ProjectContext :DbContext
    {

        public ProjectContext()
        {

        }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasData(

                new User { UserID = 1, Name = "Sezen", Surname = "Caba", UserName = "Scaba", Password = "12345", Role = "Admin" },
                new User { UserID = 2, Name = "Damla", Surname = "Çöl", UserName = "Dcol", Password = "54321", Role = "User" }

                );

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

    }
}
