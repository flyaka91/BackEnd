using Library_Management_System.DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DAL.Configurations;

internal static class BookConfiguration
{
    internal static void AddBookConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasMany(b => b.Applications)
            .WithOne(t => t.Book);
        
        modelBuilder.Entity<Book>()
            .Property(u => u.BookName)
            .IsRequired()
            .HasMaxLength(32);

        modelBuilder.Entity<Book>()
           .Property(u => u.Description)
           .IsRequired()
           .HasMaxLength(32);
           
        modelBuilder.Entity<Book>()
            .Property(u => u.Price)
           .IsRequired()
           .HasMaxLength(32);

        modelBuilder.Entity<Book>()
           .Property(u => u.Author)
          .IsRequired()
          .HasMaxLength(32);

        modelBuilder.Entity<Book>()
           .Property(u => u.PublicationDate)
          .IsRequired()
          .HasMaxLength(32);
    }
}
