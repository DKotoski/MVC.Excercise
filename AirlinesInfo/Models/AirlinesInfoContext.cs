using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public class AirlinesInfoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AirlinesInfoContext() : base("name=AirlinesInfoContext")
        {
        }

        public System.Data.Entity.DbSet<AirlinesInfo.Models.Airline> Airlines { get; set; }

        public System.Data.Entity.DbSet<AirlinesInfo.Models.Airplane> Airplanes { get; set; }

        public System.Data.Entity.DbSet<AirlinesInfo.Models.Flight> Flights { get; set; }

        public System.Data.Entity.DbSet<AirlinesInfo.Models.Airport> Airports { get; set; }
    
    }
}
