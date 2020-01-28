using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Design_Pattern
{
   public sealed class SingleTone
    {
        public static SingleTone instance;
        private  SingleTone()
        {
            
        }


        public static SingleTone getInstance()
        {
            if (instance == null)
            {
                instance = new SingleTone();
            }

            return instance;
        }


    }
}
