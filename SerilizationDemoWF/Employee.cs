using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilizationDemoWF
{
    [Serializable]
    public class Employee
    {
        public int Eid { set; get; }
        public string EName { set; get; }
        public double ESalary { set; get; }
    }
}
