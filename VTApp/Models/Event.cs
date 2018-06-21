using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        [DisplayFormat(DataFormatString="{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public virtual ICollection<Volunteer> Volunteers { get; set; }

        public Event()
        {
            Volunteers = new List<Volunteer>();
        }
    }
}
