using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.SRP
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

        // the bellow methods are not releated to User so it should not be in IUser interface
        //void LogError(string error);

        //bool SendEmail(string emailContent);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
