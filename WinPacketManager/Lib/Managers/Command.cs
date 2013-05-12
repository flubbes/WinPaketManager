using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPacketManager.Lib.Managers
{
    public interface Command
    {
        string CommandString
        {
            get;
        }

        public object[] Arguments
        {
            get;
            set;
        }

        void Run(params object[] args);
    }
}
