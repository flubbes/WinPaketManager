using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager.Lib.Managers.Commands
{
    public class RepositoryUpdateCommand : Command
    {
        public string CommandString
        {
            get { return "repupdate"; }
        }

        public object[] Arguments
        {
            get;
            set;
        }

        public void Run(params object[] args)
        {
            if (args.Length == 0)
            {
                RepositoryManager.Update();
                
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
