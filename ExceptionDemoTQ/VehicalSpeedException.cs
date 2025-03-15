using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoTQ
{
    class VehicalSpeedException:Exception
    {
        public VehicalSpeedException(string msg):base(msg) { }
    }

    class Vehical {
        public void speed(int s) {
            if (s > 120) {
                throw new VehicalSpeedException("speed greter than 120");
            }
        }
    }
}
