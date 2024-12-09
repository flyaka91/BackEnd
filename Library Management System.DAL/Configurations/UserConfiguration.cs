using Library_Management_System.DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DAL.Configurations;

internal static class UserConfiguration
{
    internal static void AddUserConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Books)
            .WithMany(b => b.Users);

        modelBuilder.Entity<User>()
            .Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(32);

        modelBuilder.Entity<User>()
           .Property(u => u.LastName)
           .IsRequired()
           .HasMaxLength(32);

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
           .IsRequired()
           .HasMaxLength(32);

        modelBuilder.Entity<User>()
           .Property(u => u.PhoneNumber)
          .IsRequired()
          .HasMaxLength(32);
}
}
