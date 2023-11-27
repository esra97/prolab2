using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    internal interface IReservable
    {
        void CheckSeatAvailability();
        void ReserveSeat();
    }
}
