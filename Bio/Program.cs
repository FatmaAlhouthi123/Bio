﻿using System;

namespace Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the main menu!");
            Console.WriteLine("choose 1 to continue or 0 to close!");
            CustomerChoose();




        }

        static void CustomerChoose()
        {
             int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {

                case 0:
                    // close program
                    break;


                case 1:
                    // start program
                    Ticket ticket = new Ticket();
                ticket.TicketPris();
                    Console.WriteLine(" The total price is  " + ticket.TotalTicketsCost());
                   







                    break;
                default:
                    Console.WriteLine("Wrong input ! please choose 1 to continue or 0 to close");
       
                    CustomerChoose();
                    break;


            }
        }
    }
}
