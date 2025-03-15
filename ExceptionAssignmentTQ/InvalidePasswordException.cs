using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignmentTQ
{
    //2.WAP to create a custom exception on invalid password
    public class InvalidePasswordException : Exception
    {
        public InvalidePasswordException(string msg) : base(msg) { }
    }
    public class ValidePassword{
        public void checkPassword(string pass) {
            if (pass.Length < 8)
            {
                throw new InvalidePasswordException("Invalide Password ,Min 8 chars");
            }
            else {
                Console.WriteLine("Valide password");
            }
        }
    }
}
