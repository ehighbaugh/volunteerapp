using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VTApp.Models;

namespace VTApp.Data
{
    public class VolunteerAppContext : DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Event> Events { get; set; }

        public VolunteerAppContext()
        {
            // This call to the SetInitializer method is used 
            // to configure EF to use our custom database initializer class
            // which contains our app's database seed data.
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Using the fluent API to configure the precision and scale
            // for the ComicBook.AverageRating property.
            //modelBuilder.Entity<ComicBook>()
            //    .Property(cb => cb.AverageRating)
            //    .HasPrecision(5, 2);
        }
    }
}