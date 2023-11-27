using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Trip
    {
        public List<Route> RouteList = new List<Route>();
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }
    }
}
