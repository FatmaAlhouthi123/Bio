using System;
using System.Collections.Generic;
using System.Text;

namespace Bio
{
    class Customer
    {
         static int n;

        public int CustomerAge()
        {
            if (n == 0)
                Console.WriteLine(" please enter age of customer ");
            else 
                Console.WriteLine(" please enter age of next customer ");

            int customerAge = int.Parse(Console.ReadLine());
            
            n++;
           
            return customerAge;
           
        }




    }
}
