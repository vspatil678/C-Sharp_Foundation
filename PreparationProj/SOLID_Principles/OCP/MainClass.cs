using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.OCP
{
   public class MainClass
    {

        public static void Main1(string[] args)
        {
            Employee pemp = new PermanentEmployee(1, "jhon");
            Employee cemp = new ContractEmployee(2, "MEchdol");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", pemp.ToString(),
                pemp.CalculateBonus(100000).ToString()));

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", cemp.ToString(),
                cemp.CalculateBonus(100000).ToString()));
            Console.ReadLine();
        }
    }
}
