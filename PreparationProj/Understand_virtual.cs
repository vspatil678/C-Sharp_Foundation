using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
    class TestClass
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                Console.WriteLine("shape class");
                return x * y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                Console.WriteLine("Circle class");
                return PI * x * x;
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                Console.WriteLine("Sphere class");
                return 4 * PI * x * x;
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                Console.WriteLine("Cylinder class");

                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        static void Main()
        {
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            Console.ReadLine();
        }
    }
}

/*
 * The virtual keyword is used to modify a method, property, indexer, or event declaration and
 * allow for it to be overridden in a derived class.
 * The implementation of a virtual member can be changed by an overriding member in a derived class. 
 * You cannot use the virtual modifier with the static, abstract, private, or override modifiers.
 * A virtual inherited property can be overridden in a derived class by including a 
 * property declaration that uses the override modifier.
 * */
