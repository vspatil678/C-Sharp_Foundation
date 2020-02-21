using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Logical_Programs
{
    class LogicsOnString
    {

        public static void Main1(string[] args)
        {
            string data = " The Traveller ";
          //  ReverseString(data);
            palindrome("GADAG1");
            Console.ReadLine();
        }

        private static void ReverseString(string input)
        {
            string output = null;
            for(int i=input.Length - 1; i >= 0; i--)
            {
                output = output + input[i];
            }
            Console.WriteLine(output);
        }

        private static void palindrome(string input)
        {
            string output = null;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output = output + input[i];
            }

            if(input == output)
            {
                Console.WriteLine("given string is Palindrome");
            } else
            {
                Console.WriteLine("Given string is not Palindrome");
            }
        }
    }
}
