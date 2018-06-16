using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String Date { get; set; }
        public String StartTime { get; set; }
        public String EndTime { get; set; }

        public ICollection<Volunteer> Volunteers { get; set; }
        public ICollection<Organization> Organizations { get; set; }
    }
}