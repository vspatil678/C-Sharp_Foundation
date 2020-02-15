using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProj.Task_and_Thread
{
   public class Understand_Task
    {
        public Understand_Task()
        {

        }
        public static void Method1()
        {
            Console.WriteLine("Method 1 Exection");
        }

        public async static Task Method2()
        {
            await Task.Run(
                () => { Task.Delay(1000000); Console.WriteLine(" Method 2 Execution"); }
                );
        }


        public static void Method3()
        {
            Console.WriteLine("Method 3 Exection");
        }
        public async Task RunAllMethods()
        {
            Method1();
            await Method2();
            Method3();
        }
    }

    public class MainClassT
    {
        public static void Main1(string[] args)
        {
            // sequential exection if no async and await
            //Method1();
            //Method2();
            //Method3();


            // sequential exection will happen when methods dosent have async and await
            //Task.Run(() => {
            //    Method1();
            //    Method2();
            //    Method3();
            //    }
            //);

            // when all methods have async and await asynchronous execution will happen (non- sequentional)
            //Task.Run(() => {
            //    Method1();
            //    Method2();
            //    Method3();
            //});

            Understand_Task understand_Task = new Understand_Task();
            understand_Task.RunAllMethods();

            Console.ReadLine();
        }

        //public async static Task Method1()
        //{
        //    await Task.Run(
        //        () => Console.WriteLine(" Method 1 Execution")
        //        );
        //}

        //public async static Task Method2()
        //{
        //    await Task.Run(
        //        () => Console.WriteLine(" Method 2 Execution")
        //        );
        //}

        //public async static Task Method3()
        //{
        //    await Task.Run(
        //        () => Console.WriteLine(" Method 3 Execution")
        //        );
        //}

        //public static void Method1()
        //{
        //    Console.WriteLine("Method 1 Exection");
        //}

        //public static void Method2()
        //{
        //    Console.WriteLine("Method 2 Exection");
        //}

        //public static void Method3()
        //{
        //    Console.WriteLine("Method 3 Exection");
        //}

        

    }
}

/*
 * if methods dosent have async await these will run sequentially
 * 
 * */
