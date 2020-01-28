using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.OCP
{
   public abstract class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

       // public string EmployeeType { get; set; }
        public Employee()
        {

        }

        //public Employee(int id, string name, string empType)
        //{
        //    this.ID = id; this.Name = name; this.EmployeeType = empType;
        //}


        public Employee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);
        
        public override string ToString()
        {
            return string.Format($"Id: {this.ID}, name: { this.Name}");
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {

        }

        public PermanentEmployee(int id, string name): base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }


    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        {

        }

        public ContractEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

}
