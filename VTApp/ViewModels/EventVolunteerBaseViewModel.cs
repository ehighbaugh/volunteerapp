using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Web.Mvc;
using VTApp.Data;
using VTApp.Models;

namespace VTApp.ViewModels
{
    /// <summary>
    /// Base ViewModel class for Add/Edit EventVolunteer views;
    /// </summary>
    public class EventVolunteerBaseViewModel
    {
        public Event Event { get; set; } = new Event();

        public SelectList VolunteerSelectListItems { get; set; }

        /// <summary>
        /// Inits view model;
        /// </summary>
        public virtual void Init()
        {
            VolunteerSelectListItems = new SelectList(
                new List<Volunteer>(),
                "Id", "Name");
        }
    }
}