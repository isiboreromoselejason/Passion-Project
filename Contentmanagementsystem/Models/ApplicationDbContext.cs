using Contentmanagementsystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Contentmanagementsystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactCategoryMap> ContactCategoryMaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactCategoryMap>()
                .HasKey(cc => new { cc.ContactId, cc.CategoryId });

            modelBuilder.Entity<ContactCategoryMap>()
                .HasOne(cc => cc.Contact)
                .WithMany(c => c.ContactCategoryMaps)
                .HasForeignKey(cc => cc.ContactId);

            modelBuilder.Entity<ContactCategoryMap>()
                .HasOne(cc => cc.Category)
                .WithMany(c => c.ContactCategoryMaps)
                .HasForeignKey(cc => cc.CategoryId);
        }
    }
}