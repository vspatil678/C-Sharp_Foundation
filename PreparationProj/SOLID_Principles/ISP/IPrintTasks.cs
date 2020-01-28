using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.SOLID_Principles.ISP
{
   public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);

        // this is newly added method but IprintTasks forcing all its implemented classes to impliment bellow method
        // we can segregate the interface 
        // bool PrintDuplexContent(string content);
    }
}
