using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Collection
{
    class Understand_HashTable
    {
        public static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            try
            {
                
                hashTable.Add("txt4", " some value 1");
                hashTable.Add("txt2", " some value 2");
                hashTable.Add("txt1", " some value 3");
                hashTable.Add("txt3", " some value 4");
                hashTable.Add(1, " some value 5");
                hashTable.Add(true, " some value 6");
                // key should not be null
                // hashTable.Add(null, " some value 7");

                // key should be unique
                //hashTable.Add(1, " some value 5");

                // update value if key already exist
                hashTable["txt1"] = "text one value";

                // if key dose not exist it will add to the dictionary/hashtable
                hashTable["txt11"] = "unknown key is added";

                // ContainsKey method is used to check the existance of key
                if (!hashTable.ContainsKey("txt1"))
                {
                    hashTable.Add("txt1", "we can add like this");
                } else
                {
                    var value = hashTable["tx1"];
                    hashTable["txt1"] = "new updated value";
                }

            }
            catch (Exception)
            {

                throw;
            }

            // elements are retrived KeyValuePair
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key +"  "+ item.Value);
            }
            Console.WriteLine("--------------------- collection of keys---------");
            // collection of keys
            foreach (var item in hashTable.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------- collection of values---------");
            // collection of keys
            foreach (var item in hashTable.Values)
            {
                Console.WriteLine(item);
            }

            // hashtable will not throw exception if key dosent exist, it will return null
            Console.WriteLine("--------- key not exist but checking ------");
            Console.WriteLine(hashTable["vinod"]);

            Console.ReadLine();
        }
    }
}

/*
 * Represents a collection of key/value pairs that are organized bassed on the hash code of the key
 * key and value can be anything but key should be unique
 * key should not be null
 * to iterate HashTable - DictionaryEntry is efficient
 * use Remove method to remove object from hashtable
 * 
 * 
 * 
 * Each element is a key/value pair stored in a DictionaryEntry object
 * A key cannot be null, but a value can be.
 * We don't recommend that you use the Hashtable class for new development.
 * Instead, we recommend that you use the generic Dictionary<TKey,TValue> class.
 * */
