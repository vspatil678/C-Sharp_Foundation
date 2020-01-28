using System;
using System.Collections.Generic;
using System.Text;
using PreparationProj.SOLID_Principles.LSP.Interfaces;

namespace PreparationProj.SOLID_Principles.LSP
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set ; }
        public string name { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return base.ToString();
        }
        public abstract decimal getMinimumSalary();
        
    }
}
