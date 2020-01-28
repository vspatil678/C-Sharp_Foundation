using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.LSP.Interfaces
{
   public interface IEmployeeBonus
    {
        abstract decimal CalculateBonus(decimal salary);

    }
}
