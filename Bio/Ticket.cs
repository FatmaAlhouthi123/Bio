using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bio
{
    class Ticket
    {
        int ticketsPrice = 0;
        public void TicketPris()
        {
            Console.WriteLine(" Our ticket prices are  ");
            Console.WriteLine("  Junior  : 80 :- ");
            Console.WriteLine("  Senior  : 90 :- ");
            Console.WriteLine("  Adult  : 120 :- ");
        }

        public int TicketCount()
        {
            Console.WriteLine("  please enter how many tickets do you want  ");
            int ticketsCount = int.Parse(Console.ReadLine());
            return ticketsCount;
        }

        public  void VerifyTicketPrice()

        {
            Customer customer = new Customer();
            int age = customer.CustomerAge();
            
            if (age <= 18 )
            
                ticketsPrice = 80;

            else if (age >= 64)

                ticketsPrice = 90;
            else
                ticketsPrice = 120;



        }

        public int TotalTicketsCost()
        {
            int totalTicketPrice= 0;
            int number = TicketCount();
            
            for (int i=0; i < number; i++)
            {
                VerifyTicketPrice();
                totalTicketPrice += ticketsPrice;
            }

            return totalTicketPrice;
        }













    }

}
 