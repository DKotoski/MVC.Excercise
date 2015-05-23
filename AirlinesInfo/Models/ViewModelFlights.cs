using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public class ViewModelFlights
    {
        public int FlightNumber { get; set; }
        public string Status { get; set; }
        public string PlaneType { get; set; }
        public string Arival { get; set; }
        public string Departure { get; set; }
    }
}