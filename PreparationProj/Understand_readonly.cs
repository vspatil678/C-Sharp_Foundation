using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
   public class Understand_readonly
    {
        /* In this example, the value of the field year can't be changed in the method ChangeYear,
         * even though it's assigned a value in the class constructor :
         */
        readonly int year;
        public Understand_readonly(int _year)
        {
           year = _year;
        }

        void changeYear()
        {
            //  year = 1993; // Compile error if uncommented.
        }

        // You can assign a value to a readonly field only in the following contexts:
        // 1- When the variable is initialized in the declaration, for example:
        public readonly int y = 5;
        
        // 2- In an instance constructor of the class that contains the instance field declaration.
        // 3- In the static constructor of the class that contains the static field declaration.


    }

    public class SampleClass
    {
        public int x;
        public readonly int y = 25;
        public readonly int z;

        // initialize readonly instance field
        public SampleClass()
        {
            y = 30;
            z = 24;

            Console.WriteLine($"y= {y} z={z}");
        }
        public SampleClass(int p1, int p2, int p3)
        {
            x = p1; y = p2; z = p3;
        }

        public static void Main(string[] args)
        {
            SampleClass sc = new SampleClass(11, 22, 33);
            Console.WriteLine($"x = {sc.x} y = { sc.y} z= {sc.z}");

            SampleClass sc2 = new SampleClass();
            sc2.x = 55;

            Console.WriteLine($"sc2: x={sc2.x}, y={sc2.y}, z={sc2.z}");

           // sc2.y = 66;        // Error
        }
    }
}

// readonly field cannot be assigned to (except in a constructor or a variable initializer )
