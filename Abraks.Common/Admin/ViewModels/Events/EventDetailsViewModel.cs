namespace Abraks.Common.Admin.ViewModels.Events
{
    using System;

    public class EventDetailsViewModel
    {
        public string Name { get; set; }

        public string Dance { get; set; }
        
        public string Place { get; set; }

        public string Address { get; set; }
        
        public string PosterUrl { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
    }
}
