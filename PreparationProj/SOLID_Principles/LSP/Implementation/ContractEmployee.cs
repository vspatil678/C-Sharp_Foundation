using System;
using System.Collections.Generic;
using System.Text;
using PreparationProj.SOLID_Principles.LSP.Interfaces;

namespace PreparationProj.SOLID_Principles.LSP.Implementation
{
    class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string name { get; set; }

        public ContractEmployee()
        {

        }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.name = name;
        }
        public decimal getMinimumSalary()
        {
            return 5000;
        }
    }
}
