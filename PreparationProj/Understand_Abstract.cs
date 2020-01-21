using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj
{
    public interface InterfaceA
    {
        void interfaceMtthodA();
    }

   abstract public class SimpleClass : InterfaceA
    {

        // override keyword is not required 
        abstract public void interfaceMtthodA();
        

    }
    public abstract class Understand_Abstract : InterfaceA
    {
      abstract public void Method1();
      abstract  public int MyProperty1 { get; set; }
        public void Method2()
        {
            Console.WriteLine(MyProperty1);
        }

       abstract public void Method3();

         public void interfaceMtthodA() { }
        
    }

    abstract public class MainClass2 : Understand_Abstract
    {
        
        public override int MyProperty1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Method1()
        {

        }

       abstract  public override void Method3();
        public static void Main2(string[] args)
        {

        }

        
    }
    // abstract
    /*
     * The abstract modifier indicates that missing or incomplete implementation.
     * The abstract modifier can be used with classes, methods, properties, indexers, and events.
     * whenever we are inheriting abstract class the derived class  must implement all the base class
     * abstract methods in the derived class with override keyword.
     * if you dont want to implement in the derived class also make it as abstract method with override
     * Ex- abstract  public override void Method3();
     * and Mark that class has abstract class
     * 
     * An abstract class cannot be instantiated.
     * An abstract class may contain abstract methods and accessors.
     * It is not possible to modify an abstract class with the sealed modifier because the two modifiers 
     * have opposite meanings. The sealed modifier prevents a class from being inherited and 
     * the abstract modifier requires a class to be inherited.
     * an abstract class cannot be sealed or static 
     * An abstract method is implicitly a virtual method. and cannot  be marked as virtual
     * Abstract method declarations are only permitted in abstract classes.
     * Because an abstract method declaration provides no actual implementation, there is no method body;
     * It is an error to use the abstract modifier on a static property.
     * An abstract inherited property can be overridden in a derived class by including a property declaration
     * that uses the override modifier.
     * 
     * whenever class(non abstract class) that extends or implements a interface it should give implementation 
     * to the interface method(without override keyword) or mark that class as a abstract class and method as abstract method
     * 
     * whenever abstract class that extends or implements the interface it can implement the interface method
     * (without override keyword) or make it an abstract method
     * 
     * abstract methods cannot be private
     */
}
