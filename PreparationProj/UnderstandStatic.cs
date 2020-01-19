using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
    // public static class UnderstandStatic
    public static class UnderstandStatic
    {
        // constant variables cannot be marked as static
        // public static const int constVariable = 20;

        static UnderstandStatic()
        {

        }
       
        public static int y;
       
        public static int  x = 10;
        //public int y = 20;

        //public void Method1()
        //{

        //}
      
        public static void Method2()
        {

        }
        public static void Method2(int x)
        {

        }
    }

    public class NonStaticClass
    {
        public NonStaticClass()
        {
            Console.WriteLine("ctor in nonstatic class");
        }
        static NonStaticClass()
        {
            variable1 = 20;
            Console.WriteLine("static ctor in non-static class "+ variable1);
        }
        public static int variable1;
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            UnderstandStatic.x = 20;
            UnderstandStatic.x = 30;
            UnderstandStatic.x = 40;
            Console.WriteLine(UnderstandStatic.x); // 40

            NonStaticClass.variable1 = 20;
            NonStaticClass.variable1 = 30;
            NonStaticClass.variable1 = 40;
            Console.WriteLine(NonStaticClass.variable1); // 40

            NonStaticClass n1 = new NonStaticClass();
            

            
        }
    }
}

// static class
/*
 *  static class should contain only static properties (variables and methods and constructor should be static)
 *  we cant create object for the static class compiler error
 *  we canot inherit the static class
 *  if constructor in the static class that should be static constructor
 *  static constructor should not have any access specifiers
 *  static classes are sealed classes
 *  A static constructor is only called one time,
 *  and a static class remains in memory for the lifetime of the application 
 *  domain in which your program resides.
 *  Static methods can be overloaded but not overridden, because they belong to the class
 *  Static constroctor must be parameterless
 *  Static members are initialized before the static member is accessed for the first time
 *  and before the static constructor, if there is one, is called.
 *  constant variables cannot be marked as static
 *  if class have static ctor and non static ctor - static ctor will execute first
 * */
