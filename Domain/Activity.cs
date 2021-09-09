
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }

        public String Title { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }

        public String City { get; set; }

        public String Venue { get; set; }
        public Boolean IsCancelled { get; set; }
        public ICollection<ActivityAttendee> Attendees { get; set; } = new List<ActivityAttendee>();

    }
}