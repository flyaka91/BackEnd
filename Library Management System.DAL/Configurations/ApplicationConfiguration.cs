using Library_Management_System.DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.DAL.Configurations
{
    internal static class ApplicationConfiguration
    {
        internal static void AddApplicationConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasOne(b => b.Book)
                .WithMany(t => t.Applications);
        }   
    }
}
