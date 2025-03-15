using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public delegate void AlertDel(string msg);
    class AlertDevice
    {
         public void AlertPhone(string msg)
        {
            Console.WriteLine("Alerting Phone....{0}", msg);
        }

        public void AlertDesktop(string msg)
        {
            Console.WriteLine("Alerting Desktop....{0}", msg);
        }

        public void AlertTablet(string msg)
        {
            Console.WriteLine("Alerting Tablet....{0}", msg);
        }
    }
    internal class Program
    {   static void Main(string[] args)
        {
            AlertDevice dev = new AlertDevice();
            AlertDel alert = new AlertDel(dev.AlertPhone);
            alert += dev.AlertTablet;
            alert += dev.AlertDesktop;
            alert.Invoke("ok");


        }
    }
}
