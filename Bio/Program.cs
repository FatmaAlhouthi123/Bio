using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Bio
{
    class Program
    {
       /// <summary>
       /// /
       /// </summary>
       /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool x = true;


            Console.WriteLine("Welcom to the main menu!");
            while (x)
            {
                Console.WriteLine("choose 1 to continue , choose 2 to type a sentence 10 times, 3 to chhose last word att sentence  or 0 to close!");
                CustomerChoose();


                Console.WriteLine("what do you want to do type 1 to go to main menu or 0 eo exit program");
                int whatNext = int.Parse(Console.ReadLine());
                if (whatNext == 0) x = false;
                else x = true;
            }
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
                    ticket.Demo();
                        Console.WriteLine($" The total price is   {ticket.TotalTicketsCost()}");
                        break;

                   
                    
                case 2:
                    //Menyval 2: Upprepa tio gånger
                    Console.WriteLine(" enter the sentence that you want to type 10 times");
                    Repeat repeat = new Repeat();
                    repeat.Iteraiton();
                  break;


                case 3:
                    //Menyval 3: Det tredje ordet
                    Console.WriteLine(" enter the sentence that you want to get the last word printed");
                    StringDevider stringDevider = new StringDevider();
                    Console.WriteLine(stringDevider.LastwordBuilder());

                    break;
                default:
                    Console.WriteLine(" Wrong input! please choose 1 to continue or 0 to close");
       
                    CustomerChoose();
                    break;
            }
                
        }
        
    }
}
