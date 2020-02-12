using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.DIP
{
    public class DataAccessLayer
    {

        public void Save(Object details)
        {
            //perform save
        }
    }

    public class DataAccessLAyerDIP : IRepositoryLayer
    {
        public void Save(Object details)
        {
            // logic for save
        }
    }
}
