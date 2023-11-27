using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    // Reservation sınıfı: Rezervasyonları temsil eden bir class
    public class Reservation
    {
        public Passenger Passenger { get; set; }
        public Vehicle Vehicle { get; set; }
        public int SeatNumber { get; set; }
    }

}
