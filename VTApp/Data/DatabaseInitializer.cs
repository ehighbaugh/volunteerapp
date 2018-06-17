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
            context.Events.AddOrUpdate(x => x.ID,
                new Event() { ID = 1, Name = "Blood Drive", Date = "01/01/2018", StartTime = "08:00", EndTime = "4:00" },
                new Event() { ID = 2, Name = "Gala", Date = "21/01/2018", StartTime = "06:00", EndTime = "12:00" },
                new Event() { ID = 3, Name = "Animal Adoption", Date = "31/01/2018", StartTime = "10:00", EndTime = "2:00" }
                );

            context.Organizations.AddOrUpdate(x => x.ID,
                new Organization() { ID = 1, OrgName = "Humane Society", Cause = "Animal welfare", ContactName = "Sue Smith", Email = "sue@humane.org", Phone = "5025551212" },
                new Organization() { ID = 2, OrgName = "County Hospital", Cause = "healthcare", ContactName = "Bob Barker", Email = "bob@hosp.org", Phone = "5022221212" },
                new Organization() { ID = 3, OrgName = "City Society", Cause = "college scholarships", ContactName = "Carl Sagan", Email = "carl@city.org", Phone = "50254441212" }
                );

            context.Volunteers.AddOrUpdate(x => x.ID,
                new Volunteer() { ID = 1, Name = "Sarah Miller", Email = "sarah@gmail.com", Phone = "1234567890", Birthday = "02/20/1995" },
                new Volunteer() { ID = 1, Name = "Joyce Rich", Email = "joyce@gmail.com", Phone = "5025025022", Birthday = "06/29/1954" },
                new Volunteer() { ID = 1, Name = "David Harkin", Email = "david@gmail.com", Phone = "1234561230", Birthday = "08/08/1988" }
                );
        }

    }
}