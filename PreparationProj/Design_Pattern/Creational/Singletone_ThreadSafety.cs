using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProj.Design_Pattern.Creational
{
   public sealed class Singletone_ThreadSafety
    {
        private static int counter = 0;

        // use bellow object as lock object
        private static readonly object obj = new object();
        public Singletone_ThreadSafety()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }
        // lazy initializaion
        private static Singletone_ThreadSafety instance = null;

        public static Singletone_ThreadSafety GetInstance()
        {
            // it will create multiple objects in multithreaded situation
            //if(instance == null)
            //{
            //    instance = new Singletone_ThreadSafety();
            //}

            // to avoid this situaton thread lock is the solution (to control thread race situation)
            // lock 
            // when employee and students try to create object at same time the lock will prevent by 
            // allowing first one completion and next one will wait until completon of first one
            //lock (obj)
            //{
            //    if(instance == null)
            //    {
            //        instance = new Singletone_ThreadSafety();
            //    }
            //}

            // Note: Locks are very expensive and no need to use lock every time 
            // how to avoid unnecessary lock checking -- null check with instance

            if(instance == null)
            {
                // https://en.wikipedia.org/wiki/Double-checked_locking
                lock (obj)
                {
                    if(instance == null)
                    {
                        instance = new Singletone_ThreadSafety();
                    }
                }

            }


            return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainClassTs
    {
        public static void Main1(string[] args)
        {
            // single threaded and sequential execution
            //PrintEmployeeDetails();
            //PrintStudentDetails();

            // convert to multithreaded and non sequential execution 
            // Parallel.Invoke method executes given action parallely
            // this creates two objects of singletone class this violates the singletone pattern
            // to avoid this situaton thread lock is the solution (to control thread race situation)
            Parallel.Invoke(
                () => PrintStudentDetails(),
                () => PrintEmployeeDetails()
                );
        }

        private static void PrintStudentDetails()
        {
            Singletone_ThreadSafety fromStudent = Singletone_ThreadSafety.GetInstance();
            fromStudent.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetails()
        {
            Singletone_ThreadSafety fromEmployee = Singletone_ThreadSafety.GetInstance();
            fromEmployee.PrintDetails("From Employee");
        }
    }
}

/*
 * Lazy initialization is works fine in single threaded
 * 
 * */
