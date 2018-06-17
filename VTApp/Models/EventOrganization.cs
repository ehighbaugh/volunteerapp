using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class EventOrganization
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int OrganizationId { get; set; }
        public int VolunteerId { get; set; }

        public Event Event { get; set; }
        public Organization Organization {get; set;}
        public Volunteer Volunteer { get; set; }

    }
}