using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class User, create a method with name AccpetName(string name),
     * convert the name in upper case & return.
    Create the delegate to hold AcceptName method reference & invoke using delegate*/
namespace DelegateDemoTQ
{
    public delegate string Mydelegate(string s);
    public  class User
    {   
       
        public string AcceptName(string name) { 
            return name.ToUpper();
        }
    }
}
