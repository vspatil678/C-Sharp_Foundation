using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProj.Design_Pattern.Creational
{
   public sealed class Singletone_ThreadSafety_EagerInit
    {
        private static int counter = 0;

        public Singletone_ThreadSafety_EagerInit()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }
        // non lazy initializaion (Eager initializaion)
        private static readonly Singletone_ThreadSafety_EagerInit instance = new Singletone_ThreadSafety_EagerInit();

        public static Singletone_ThreadSafety_EagerInit GetInstance()
        {
           return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainClassEager
    {
        public static void Main1(string[] args)
        {
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
 * Eager intialization works fine with Multithreade
 * we no need to explictly mention null check or lock 
 * run time clr will take care 
 * */
