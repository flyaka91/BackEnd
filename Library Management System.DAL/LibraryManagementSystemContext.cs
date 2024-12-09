using Library_Management_System.DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Library_Management_System.DAL.Configurations;


namespace Library_Management_System.DAL
{
    public class LibraryManagementSystemContext : DbContext
    
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Application> Applications { get; set; }

        public LibraryManagementSystemContext(DbContextOptions<LibraryManagementSystemContext> options) : base(options)

        {
        //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddApplicationConfiguration();
            modelBuilder.AddUserConfiguration();
            modelBuilder.AddUserConfiguration();
        }
    }
}
