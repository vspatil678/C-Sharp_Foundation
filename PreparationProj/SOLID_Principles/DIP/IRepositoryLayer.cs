using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.DIP
{
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }
}
