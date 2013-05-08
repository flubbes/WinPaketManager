using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPaketManager.Lib
{
    public class PaketNotFoundException : KeyNotFoundException
    {
        public PaketNotFoundException(string paketName)
        {
            this.PaketName = paketName;
        }

        public string PaketName
        {
            get;
            private set;
        }
    }
}
