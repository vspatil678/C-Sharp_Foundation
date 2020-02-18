using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PreparationProj.Collection;

namespace PreparationProj.Collection
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Collection of Person objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class People : IEnumerable
    {
        private Person[] _people;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        // Implementation for the GetEnumerator method.
       public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    public class Understand_IEnumerable
    {

        public static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };

            People peopleList = new People(peopleArray);
            foreach (var people in peopleList)
            {
                Console.WriteLine(people.FirstName + "   " + people.LastName);
            }
        }
    }
}

// When you implement IEnumerable, you must also implement IEnumerator.
public class PeopleEnum : IEnumerator
{
    public Person[] _people;

    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;

    public PeopleEnum(Person[] list)
    {
        _people = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Person Current
    {
        get
        {
            try
            {
                return _people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}

/*
 * Exposes an enumerator, which supports a simple iteration over a non-generic collection.
 * IEnumerable is the base interface for all non-generic collections 
 * IEnumerable contains a single method, GetEnumerator, which returns an IEnumerator.
 * IEnumerator provides the ability to iterate through the collection by exposing a 
 * Current property and MoveNext and Reset methods.
 * // When you implement IEnumerable, you must also implement IEnumerator.
 * */
