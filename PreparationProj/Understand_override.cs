using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
    public abstract class Shape
    {
        public abstract int GetArea();
    }

   public class Understand_override : Shape
    {
        public int side;
        public Understand_override(int n)
        {
            side = n;
        }

        public  override int GetArea()
        {
            return side * side;
        }

        public static void Main1(string[] args)
        {
            Understand_override understand_Override = new Understand_override(12);
            Console.WriteLine(understand_Override.GetArea()); ;
        }

    }
    /*
     * the override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, 
     * modify, property, indexer, or event
     * You cannot override a non-virtual or static method. 
     * The overridden base method must be virtual, abstract, or override.
     * An override declaration cannot change the accessibility of the virtual method.
     * Both the override method and the virtual method must have the same access level modifier.
     * You cannot use the new, static, or virtual modifiers to modify an override method.
     * virtual methods can be override
     * */
}
