using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Cause { get; set; }

        public ICollection<EventOrganization> Events { get; set; }
        public ICollection<Volunteer> Volunteers { get; set; }


        public Organization()
        {
            Events = new List<EventOrganization>();
        }
    }
}