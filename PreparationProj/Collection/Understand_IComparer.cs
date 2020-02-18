using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PreparationProj.Collection
{

    public class Employee
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Employee(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }

    public class EmployeeAgecomparer : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (x.Age == y.Age)
                return 0;
            if (x.Age < y.Age)
                return -1;
            return 1;
        }
    }

    public class EmployeeNamecomparer : IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class Understand_IComparer
    {
        public static void Main1(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1993, "vinod"),
                new Employee(2000, "BMW"),
                new Employee(1864, "Toyota")
            };
            DisplayListItems(employees);
            Console.WriteLine("----------------");
            // employees.Sort(new EmployeeAgecomparer());
            employees.Sort(new EmployeeNamecomparer());
            DisplayListItems(employees);

        }

        private static void DisplayListItems(List<Employee> values)
        {
            foreach (var emp in values)
            {
                Console.WriteLine(emp.Name + "  " + emp.Age);
            }
        }
    }
}
