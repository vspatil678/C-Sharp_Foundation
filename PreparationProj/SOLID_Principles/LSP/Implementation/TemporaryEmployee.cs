using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.LSP.Implementation
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {

        }

        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal getMinimumSalary()
        {
            return 5000;
        }
    }
}
