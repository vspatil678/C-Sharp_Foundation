using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
    class A
    {
        // it will be not available in the derived class until creating the reference 
        // A a = new A(); a. will provide methods
        public void NonVirtualMethod()
        {
            Console.WriteLine("print NonVirtualMethod");
        }
        // make method as virtual then only it will be available within derived class 
        // otherwise you have to create object and access it through reference
        public virtual void Print1()
        {
            Console.WriteLine("print 1");
        }

        // for overriding methods only we have to use sealed modifier
        //public sealed void Print2()
        //{
        //    Console.WriteLine("print 2 sealed");
        //}

    }

   sealed  class B : A
    {
       
        public  void PrintB()
        {
            Console.WriteLine("print B");
        }

        public sealed override void Print1()
        {
            Console.WriteLine("we can override virtual methods from base");
        }
    }
    // sealed class cant inherit
    //class C : B
    //{
        
    //}
    class Understand_sealed
    {
        public static void Main11(string[] args)
        {
            
        }
    }

    
}

/*
 * When applied to a class, the sealed modifier prevents other classes from inheriting from it.
 * in sealed class we should not have virtual methods
 * sealed and abstract cannt be together
 * it is not possible to inherit or override sealed methods
 * variables should not be sealed
 * */
