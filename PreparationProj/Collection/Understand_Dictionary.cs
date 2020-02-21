using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Collection
{
    class Understand_Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictDemo = new Dictionary<string, string>();
            try
            {
                dictDemo.Add("txt1", " some value 1");
                dictDemo.Add("txt2", " some value 2");
                dictDemo.Add("txt3", " some value 3");
                dictDemo.Add("txt4", " some value 4");
                // key should be unique value can be anything
               // dictDemo.Add("txt4", " different value or same value");
            }
            catch (Exception ex)
            {

                throw;
            }
            // get value from key through indexers
            Console.WriteLine("For Key txt1 - value is " + dictDemo["txt1"]);

            // update value with indexer when we know key
            dictDemo["txt1"] = "Updated Value";
            Console.WriteLine("For Key txt1 - value is " + dictDemo["txt1"]);

            // add key value to the dictionary using indexers
            dictDemo["txt5"] = "using indexer";

            // indexer will throw an Exception if requested key is not found in dictionary
            try
            {
                // key not found exception
              //  Console.WriteLine(dictDemo["unknown key"]); 
            }
            catch (Exception)
            {

                throw;
            }

            Console.WriteLine("---------------------------------------------- 1");

            // TryGetValue()
            /*
             * use TryGetValue() insted of indexers when you are not sure  about key
             * TryGetValue can be a more efficient way to retrieve values.
             * */

            string outputValue;
            if (dictDemo.TryGetValue("txt2", out outputValue))
            {
                Console.WriteLine("For key txt2 " + outputValue);
            } else
            {
                Console.WriteLine("key not found - " + outputValue);
            }

            Console.WriteLine("---------------------------------------------- 2");
            // containskey method is used to check the key before inserting into the dictionary.
            // if key does not exist - add new element else update existing element
            if(!dictDemo.ContainsKey("doc"))
            {
                // adding first time
                dictDemo.Add("doc", "Adding 1st time");
            }
            // adding second time
            if (!dictDemo.ContainsKey("doc"))
            {
                dictDemo.Add("doc", "Adding 1st time");
            }
            else
            {
                // get value and update
               string valuefor =  dictDemo["doc"];
                dictDemo["doc"] = valuefor + "updated";
            }


            Console.WriteLine("----------------------------------------------  3");
            foreach (KeyValuePair<string,string> kvp in dictDemo)
            {
                Console.WriteLine("Key {0} - value {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("----------------------------------------------  4");

            // iterate key and value
            foreach (var item in dictDemo)
            {
                Console.WriteLine(item.Key + "    " + item.Value);
            }

            Console.WriteLine("----------------------------------------------  5");

            // collection of keys
            var dictDemoKeys = dictDemo.Keys;
            foreach (var keyName in dictDemoKeys)
            {
                Console.WriteLine(keyName);
            }

            Console.WriteLine("----------------------------------------------  6");

            // collection of Values
            var dictDemoValues = dictDemo.Values;
            foreach (var valueName in dictDemoValues)
            {
                Console.WriteLine(valueName);
            }

            Console.WriteLine("----------------------------------------------  7");
            // use Remove method to Remove KeyValuePair object from dictionary
            Console.WriteLine("removing key value for doc");
            dictDemo.Remove("doc");

            if(!dictDemo.Remove("doc"))
            {
                Console.WriteLine("key not found in the dictionary");
            }

            foreach (var item in dictDemo)
            {
                Console.WriteLine(item.Key + "    " + item.Value);
            }
            Console.ReadLine();
        }
    }
}

/*
 *  Key must be Unique
 *  Performance is Good compare to  hash table due to No boxing and unboxing.
 *  
 *  the Add method throws an ArgumentException when attempting to add a duplicate key.
 *  KeyNotFoundException is thrown when a requested key is not present
 *  use the ContainsKey method to test whether a key exists before calling the Add method.
 *  use TryGetValue() for Efficiency and it will not throw exception if key dosent exist.
 *  Use ContainsKey() to check the key
 *  Dictionary elements are retrived as KeyValuePair objects
 *  use Keys property to get all Keys
 *  use Values property to get all values
 *  use Remove method to remove KeyValuePair object from dictionary
 * */
