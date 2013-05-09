using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WinPaketManager.Lib.Exceptions;

namespace WinPaketManager.Lib.Objects
{
    public class Repository
    {
        string cacheIndex;
        const string repositoryIndex = "index.html";

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

        private string BuildUrl()
        {
            return Address.EndsWith("/") ? Address : Address + "/";
        }

        public void Update()
        {
            string bla = BuildUrl() + repositoryIndex;
            Stream indexStream = new WebClient().OpenRead((BuildUrl() + repositoryIndex));
            if (!indexStream.CanRead) throw new RepositoryUnreachableException(this);
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlReader.Create(indexStream));
            if (!doc.HasChildNodes) throw new EmptyRepositoryException(this);
            XmlNode paketNode = null;
            foreach (XmlNode node in doc.ChildNodes)
                if (node.Name == "Pakets")
                    paketNode = node;
            foreach (XmlNode node in paketNode)
                if(node.Name == "Paket")
                    Pakets.Add(new Paket(node));
        }

        public Image GetImageFromPaket(Paket p)
        {
            return Image.FromStream(new WebClient().OpenRead(BuildUrl() + p.Folder + "/" + p.Image));
        }

        public Paket GetPaket(string paketName)
        {
            foreach (Paket p in Pakets)
            {
                if (p.Name == paketName)
                    return p;
            }
            throw new PaketNotFoundException(paketName);
        }
    }
}
