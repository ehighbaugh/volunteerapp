using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using VTApp.Models;

namespace VTApp.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<VolunteerAppContext>
    {
        protected override void Seed(VolunteerAppContext context)
        {
            context.Events.AddOrUpdate(x => x.Id,
                new Event() { Id = 1, Name = "Blood Drive", Date = DateTime.Parse("01/01/2018"), StartTime = DateTime.Parse("08:00"), EndTime = DateTime.Parse("4:00"), Organization = "Red Cross" },//
                new Event() { Id = 2, Name = "Gala", Date = DateTime.Parse("01/01/2018"), StartTime = DateTime.Parse("06:00"), EndTime = DateTime.Parse("12:00"), Organization = "City Society" },
                new Event() { Id = 3, Name = "Animal Adoption", Date = DateTime.Parse("01/01/2018"), StartTime = DateTime.Parse("10:00"), EndTime = DateTime.Parse("2:00"), Organization = "Kentucky Humane Society"}
                );

            context.Volunteers.AddOrUpdate(x => x.Id,
                new Volunteer() { Id = 1, Name = "Sarah Miller", Email = "sarah@gmail.com", Phone = "1234567890", Birthday = "02/20/1995" },
                new Volunteer() { Id = 1, Name = "Joyce Rich", Email = "joyce@gmail.com", Phone = "5025025022", Birthday = "06/29/1954" },
                new Volunteer() { Id = 1, Name = "DavId Harkin", Email = "davId@gmail.com", Phone = "1234561230", Birthday = "08/08/1988" }
                );
        }

    }
}