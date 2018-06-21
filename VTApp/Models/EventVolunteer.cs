using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class EventVolunteer
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int VolunteerId { get; set; }

        public Event Event { get; set; }
        public Volunteer Volunteer { get; set; }
    }
}