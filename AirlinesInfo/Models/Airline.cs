using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Airplane> Planes { get; set; }
    }
}