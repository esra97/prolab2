using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public abstract class Vehicle
    {
        public string id { get; set; }
        public string fuelType { get; set; }
        
        public string Model { get; set; }
        public int Capacity { get; set; }
       public Trip trip = new Trip();
         public abstract void CalculateFuelCost();
    }
}
