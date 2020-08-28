using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bio
{
    class StringDevider
    {
        string input;
        public StringBuilder Input()
        { 
            InputChecker();
            StringBuilder sb = new StringBuilder(input);
           

            return sb;
        }

        public void InputChecker()
        {
            int x = 0;
            // User must enter 3 words att least
            
            while (true)
            {
                Console.WriteLine("please enter sentence that contains at least 3 words");
              
                input = Console.ReadLine();
                

                foreach (char ch in input)
                {
                    if (ch == ' ')
                    {
                        x++;
                    }
                   
                }
                if (x >= 2)
                    break;


            }

            }
        public StringBuilder LastwordBuilder()
        { 
            char c;

          
            StringBuilder lastWord = new StringBuilder();
            StringBuilder enterdSentence = Input();

            for (int i = 0; i < enterdSentence.Length; i++)
            {
                
                c = enterdSentence[i];
                if (c == ' ')
                {
                   lastWord.Clear();
                }
                else
                     lastWord.Append(c);

                
            }
            return lastWord;
        }
       


    }
}
