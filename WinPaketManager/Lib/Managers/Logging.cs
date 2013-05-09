using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPacketManager.Lib.Managers
{
    public static class Logging
    {
        public delegate void LogginEventArgs(string logMessage);
        public static event LogginEventArgs NewLog;

        public static void Log(string logMessage)
        {
            if (NewLog != null)
                NewLog(logMessage);
        }

        public static void Log(string logMessage, params object[] args)
        {
            if (NewLog != null)
                NewLog(string.Format(logMessage, args));
        }
    }
}
