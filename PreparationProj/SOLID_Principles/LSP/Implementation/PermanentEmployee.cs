using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.LSP.Implementation
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {

        }

        public PermanentEmployee(int id, string name) : base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal getMinimumSalary()
        {
            return 15000;
        }
    }
}
