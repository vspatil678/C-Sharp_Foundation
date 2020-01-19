using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProj
{
   public class Understand_Async
    {
        public static async void PrintNumbers()
        {
            await Task.Run(() => {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    if(i == 2)
                    {
                      var t =  Task.Yield();
                    }
                }

            });
        }

        public static void Main1(string[] args)
        {
            Understand_Async.PrintNumbers();
        }

    }

    /*
     *Use the async modifier to specify that a method, lambda expression, or anonymous method is asynchronous.
     * An async method runs synchronously until it reaches its first await expression,
     * at which point the method is suspended until the awaited task is complete.
     * If the method that the async keyword modifies doesn't contain an await expression or statement,
     * the method executes synchronously.
     * An async method can have the following return types:
     * Task
        Task<TResult>
        void
     * async methods can be static
     * 
     */
}
