using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.DIP
{
   public class BusinessLogicLayer
    {
        private readonly DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }


    public class BusinessLogicLayerDIP
    {
        private readonly IRepositoryLayer repositoryLayer;

        public BusinessLogicLayerDIP(IRepositoryLayer layer)
        {
            repositoryLayer = layer;
        }

        public void Save(Object details)
        {
            repositoryLayer.Save(details);
        }
    }
}
