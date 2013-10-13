using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class PlaceAddModel
    {
        public string Title { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}