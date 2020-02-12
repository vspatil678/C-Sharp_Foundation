using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Design_Pattern.Creational
{
   public sealed class Singletone_BaseVersion
    {
        private static int counter = 0;
        private Singletone_BaseVersion()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }

        private static Singletone_BaseVersion instance = null;

        public static Singletone_BaseVersion GetSingletone()
        {
            // Lazy initialization
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new Singletone_BaseVersion();
            }
            return instance;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainClass
    {
        public static void Main1(string[] args)
        {
            // single thread (runs sequencially)
            Singletone_BaseVersion fromEmployee = Singletone_BaseVersion.GetSingletone();
            fromEmployee.Print("From Employee");

            Singletone_BaseVersion fromStudent = Singletone_BaseVersion.GetSingletone();
            fromStudent.Print("From Student");
            Console.ReadLine();
        }
    }
}

/*
 * -- single threaded
 * Make class as Sealed class
 * Make all constractor as Private
 * private Singletone field
 * Create public static Method or getter to return Singletone instance 
 * 
 *the above code is Single threaded and not efficient(not multithreaded)
 * */
