using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public virtual Airport Departure { get; set; }
        public virtual Airport Arival { get; set; }
    }
}