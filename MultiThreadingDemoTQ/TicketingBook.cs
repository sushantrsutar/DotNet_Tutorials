using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingDemoTQ
{
    public class TicketingBook
    {
        public int AvaliableTickets = 8;
        public TicketingBook() { }
        public void Booking() {
            lock (this) {
                Console.Write("Enter Tickets : ");
                int Ticket = Convert.ToInt32(Console.ReadLine());
                if (Ticket <= AvaliableTickets)
                {
                    Console.WriteLine($"Successfuly {Ticket} tickets Booked");
                    AvaliableTickets = AvaliableTickets - Ticket;
                }
                else
                {
                    Console.WriteLine($"{Ticket} Tickets are not avaliable only {AvaliableTickets} Tickets Avaliable");
                }
            }
        }
    }
}
