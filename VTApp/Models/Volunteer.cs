﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTApp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<Volunteer> Volunteers { get; set; }

        public Volunteer()
        {

        }
    }
}