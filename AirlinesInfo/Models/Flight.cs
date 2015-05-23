using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public Airport Departure { get; set; }
        public Airport Arival { get; set; }
    }
}