using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
   public class Understand_const
    {
        public const int x = 10;
        public const string name = "vinod";
        
        public static void Main(string[] args)
        {
            // local variable
            const int asdf = 12;
            Console.WriteLine(asdf);
            Console.WriteLine(x);
        }

        // const
        /*
         * You use the const keyword to declare a constant field or a constant local.
         * Constants can be numbers, Boolean values, strings, or a null reference.
         * Don’t create a constant to represent information that you expect to change at any time.
         * const and static cannot be used together
         * 
         */
    }
}
