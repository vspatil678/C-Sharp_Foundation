using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PreparationProj
{
    class Program
    {
        // synchronous methods 
        private static void SyncMethod1()
        {
            Console.WriteLine("Executing m1");
            for(int i=0; i<10; i++)
            {
                if(i == 5)
                {
                    Task.Delay(5000);
                }
                 Console.WriteLine(i);
            }
        }

        private static void SyncMethod2()
        {
            Console.WriteLine("Executing m2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void Main11(string[] args)
        {
            /* in method 1 we have 5 sec of delay application will be in
             * sleep mode for 5 sec and method 2 will not execute
             * once method 1 is completes its execution method 2 execution will start
             * Note: Single Thread/Task is used to execute both methods
            */
            // SyncMethod1();
            // SyncMethod2();
            /*
             * ASyncMethod1() starts execution and application will not sleep for 5 sec immediately 
             * ASyncMethod2() will start execution application will not block 
             * Note: Different threads are used
             */
            //ASyncMethod1();
            //ASyncMethod2();

            //Thread t1 = new Thread(ASyncMethod1);
            //Thread t2 = new Thread(ASyncMethod2);
            //t1.Start();
            //t2.Start();

            Task tk1 = new Task(ASyncMethod1);
            Task tk2 = new Task(ASyncMethod2);
            tk1.Start();
            tk2.Start();

            Console.ReadLine();
        }

        // Asynchronous methods 
        private static async void ASyncMethod1()
        {
            Console.WriteLine("Executing m1 async");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                   await Task.Delay(5000);
                }
                Console.WriteLine(i);
            }
        }

        private static async void ASyncMethod2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Executing m2 async");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}
