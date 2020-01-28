using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.LSP.Interfaces
{
   public interface IEmployee
    {
        int ID { get; set; }

        string name { get; set; }

        decimal getMinimumSalary();
    }
}
