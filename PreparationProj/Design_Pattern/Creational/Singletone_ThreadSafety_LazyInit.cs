using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProj.Design_Pattern.Creational
{
   public sealed class Singletone_ThreadSafety_LazyInit
    {
        private static int counter = 0;

        public Singletone_ThreadSafety_LazyInit()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }
        // non lazy initializaion (Eager initializaion)
        private static readonly Lazy<Singletone_ThreadSafety_LazyInit> instance
            = new Lazy<Singletone_ThreadSafety_LazyInit>(()=> new Singletone_ThreadSafety_LazyInit());

        public static Singletone_ThreadSafety_LazyInit GetInstance()
        {
           return instance.Value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainClassLazy
    {
        public static void Main(string[] args)
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
 * by default lazy objects are thread safe
 * 
 * */
