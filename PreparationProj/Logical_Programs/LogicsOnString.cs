using System;
using System.Collections.Generic;
using System.Linq;

namespace PreparationProj.Logical_Programs
{
    class LogicsOnString
    {

        public static void Main1(string[] args)
        {
            string data = " The Traveller ";
            //  ReverseString(data);
            //  palindrome("GADAG1");
            CharacterCount("The Traveller");
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

        // program to count occurrence of each character 
        private static void CharacterCount(string input)
        {
            char[] inputArray = input.ToCharArray();
            Dictionary<char, int> charCountDict = new Dictionary<char, int>();
            for(int i =0; i< inputArray.Length; i++)
            {
                if(!charCountDict.ContainsKey(inputArray[i]))
                {
                    charCountDict.Add(inputArray[i], 1);
                } else
                {
                    int value;
                    // get existing value
                    charCountDict.TryGetValue(inputArray[i], out value);

                    // update with new value
                    charCountDict[inputArray[i]] = value + 1;
                }
            }

            foreach (KeyValuePair<char,int> kvp in charCountDict)
            {
                Console.WriteLine(kvp.Key + "   " + kvp.Value);
            }

            Console.WriteLine("---------------------------------------");
            // return max occoured value with key

            int maxOccared = charCountDict.Values.Max();
            Console.WriteLine(maxOccared);

            // get key from value
            char keyFromValue = charCountDict.FirstOrDefault(x => x.Value == maxOccared).Key;
            Console.WriteLine("Max time occared key is " + keyFromValue);
        }
    }
}
