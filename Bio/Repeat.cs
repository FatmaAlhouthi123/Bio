using System;
using System.Collections.Generic;
using System.Text;

namespace Bio
{
    class Repeat
    {
        public string Input()
        {
            string input = Console.ReadLine();

            return input;
        }


        public void Iteraiton()

        {
            string sentence = Input();
            for (int i =1 ; i < 11; i++)
            {
                Console.Write($"{i}.{sentence}, ");
            }
        }
    }
}
