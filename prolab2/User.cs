using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public abstract class User : ILoginable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void Login();
    }
}
