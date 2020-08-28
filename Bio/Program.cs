using System;

namespace Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the main menu!");
            Console.WriteLine("choose 1 to continue , choose 2 to type a sentence 10 times or 0 to close!");
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
                    ticket.Demo();
                    Console.WriteLine($" The total price is   {ticket.TotalTicketsCost()}");
                    break;

                case 2:
                    //Menyval 2: Upprepa tio gånger
                    Console.WriteLine(" enter the sentence that you want to type 10 times");
                    Repeat repeat = new Repeat();
                    repeat.Iteraiton();

                    break;
                default:
                    Console.WriteLine(" Wrong input! please choose 1 to continue or 0 to close");
       
                    CustomerChoose();
                    break;


            }
        }
    }
}
