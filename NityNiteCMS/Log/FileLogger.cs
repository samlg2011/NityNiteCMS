using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace NityNiteCMS.Log
{
    public class FileLogger
    {
        public void LogExceptoin(Exception e)
        {
            File.WriteAllLines("C://log//"+DateTime.Now.ToString("dd-MM-yyyy mm hh ss")+".txt",
                new string[]
                {
                    "Message:"+e.Message,
                    "Stacktrack:"+e.StackTrace
                });
        }
    }
}