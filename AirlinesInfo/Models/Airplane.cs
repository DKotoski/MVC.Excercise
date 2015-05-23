using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesInfo.Models
{
    public enum AirplaneLength{Small, Medium, Big}
    public class Airplane
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public AirplaneLength Length{ get; set; }
        public string Status { get; set; }
        public Flight Flight { get; set; }
    }
}