using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bio
{
    class Ticket
    {
        int ticketsPrice = 0;
        int totalTicketPrice = 0;
        int n = 0;
        int age = 0;


        public void TicketPris()
        {
            Console.WriteLine(" Our ticket prices are  ");
            Console.WriteLine("  Junior  : 80 :- ");
            Console.WriteLine("  Senior  : 90 :- ");
            Console.WriteLine("  Adult  : 120 :- ");
        }

        public int TicketCount()
        {
            int ticketsCount = int.Parse(Console.ReadLine());
            return ticketsCount;
        }

        public  void VerifyTicketPrice()
        { 
            if (age <= 18 )
            
                ticketsPrice = 80;

            else if (age >= 64)

                ticketsPrice = 90;
            else
                ticketsPrice = 120;
        }




        public int TotalTicketsCost()
        {
            
            return totalTicketPrice;
        }




        public int CustomerAge()
        {
            int customerAge = int.Parse(Console.ReadLine());
            return customerAge;
        }


        public void Demo()
        {  
            Console.WriteLine("  please enter how many tickets do you want  ");
            n = TicketCount();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" please enter age of customer ");
                age = CustomerAge();
                VerifyTicketPrice();
                totalTicketPrice += ticketsPrice;
            }

        }













        }

}
 