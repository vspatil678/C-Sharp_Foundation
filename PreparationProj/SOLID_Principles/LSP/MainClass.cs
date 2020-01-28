using System;
using System.Collections.Generic;
using System.Text;
using PreparationProj.SOLID_Principles.LSP.Implementation;
using PreparationProj.SOLID_Principles.LSP.Interfaces;

namespace PreparationProj.SOLID_Principles.LSP
{
   public class MainClass
    {
        public static void Main1(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "jhon"));
            employees.Add(new TemporaryEmployee(2, "temp emp"));
            // employees.Add(new ContractEmployee(3, "contract"));

            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                    employee.name,
                employee.CalculateBonus(100000).ToString(),
                employee.getMinimumSalary().ToString()
                ));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();
            employeesOnly.Add(new PermanentEmployee(1, "jhon"));
            employeesOnly.Add(new TemporaryEmployee(2, "temp emp"));
            employeesOnly.Add(new ContractEmployee(3, "contract"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                    employee.name,
                employee.getMinimumSalary().ToString()
                ));
            }

            Console.ReadLine();
        }
    }
}

