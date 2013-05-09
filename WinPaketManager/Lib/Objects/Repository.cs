using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPaketManager.Lib.Exceptions;

namespace WinPaketManager.Lib.Objects
{
    public class Repository
    {
        string cacheIndex;

        public Repository(string address)
        {
            this.Address = address;
            this.Pakets = new List<Paket>();
        }

        public string Address
        {
            get;
            private set;
        }

        public List<Paket> Pakets
        {
            get;
            private set;
        }

        public DateTime LastUpdate
        {
            get;
            private set;
        }

        public void Update()
        {

        }

        public Paket GetPaket(string paketName)
        {
            foreach (Paket p in Pakets)
            {
                if (p.Name == paketName)
                {
                    return p;
                }
            }
            throw new PaketNotFoundException(paketName);
        }
    }
}
