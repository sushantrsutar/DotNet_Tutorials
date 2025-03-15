using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{   /*4. Create a class Payment having a static method payBill
    If you pay the bill by cash you are not eligible for any discount  , method PayBill(double amt)
    If you pay by a  mode you get 15% discount on the bill  , method  PayBill(double amt, String mode)"
    */
    public class Payment
    {
        public static void payBill(double amt) {
            Console.WriteLine($"Payment Mode : Cash");
            Console.WriteLine($"Total amount to pay : {amt}");
        }
        public static void payBill(double amt, string mode) {
            if (mode.ToLower() != "cash")
            {
                double discount = 0.15 * amt;
                double finalamt = amt - discount;
                Console.WriteLine($"Payment mode : {mode}");
                Console.WriteLine($"Original amount : {amt}");
                Console.WriteLine($"Discount 15% : {discount}");
                Console.WriteLine($"Total amount to be paid : {finalamt}");
            }
            else {
                Console.WriteLine("For cash payment use : 'payBill(amt)'");
            }
        }
    }
}
