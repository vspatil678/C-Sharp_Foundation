using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Collection
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class People
    {

    }
   public class Understand_IEnumerable
    {

        public static void Main1(string[] args)
        {

        }
    }
}

/*
 * Exposes an enumerator, which supports a simple iteration over a non-generic collection.
 * IEnumerable is the base interface for all non-generic collections 
 * IEnumerable contains a single method, GetEnumerator, which returns an IEnumerator.
 * IEnumerator provides the ability to iterate through the collection by exposing a 
 * Current property and MoveNext and Reset methods.
 * */
