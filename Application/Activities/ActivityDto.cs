using System;
using System.Collections.Generic;
using Application.Profiles;

namespace Application.Activities
{
    public class ActivityDto
    {
        public Guid Id { get; set; }

        public String Title { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }

        public String City { get; set; }

        public String Venue { get; set; }
        public String HostUsername { get; set; }
        public Boolean IsCancelled { get; set; }

        public ICollection<AttendeeDto> Attendees { get; set; }
    }
}