using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    // Passenger sınıfı: Rezervasyon işlemi yapılırken yolcu bilgilerini içeren bir class
    // Person sınıfından extend edilecektir.
    public class Passenger : Person
    {
        public string TcNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
