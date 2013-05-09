using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPacketManager.Lib.Exceptions
{
    public class PacketNotFoundException : KeyNotFoundException
    {
        public PacketNotFoundException(string paketName)
        {
            this.PacketName = paketName;
        }

        public string PacketName
        {
            get;
            private set;
        }
    }
}
