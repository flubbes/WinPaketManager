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
using WinPaketManager.Lib.Managers;

namespace WinPaketManager.Lib.Objects
{
    public class Repository
    {
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
            Logging.Log("Updating {0}", this.Address);
            Logging.Log("Connecting to repository");
            Stream indexStream = new WebClient().OpenRead((BuildUrl() + repositoryIndex));
            Logging.Log("Connected");
            Logging.Log("Trying to read the repository");
            if (!indexStream.CanRead) throw new RepositoryUnreachableException(this);
            Logging.Log("I can read it");
            XmlDocument doc = new XmlDocument();
            Logging.Log("Loading content");
            doc.Load(XmlReader.Create(indexStream));
            if (!doc.HasChildNodes) throw new EmptyRepositoryException(this);
            XmlNode paketNode = null;
            foreach (XmlNode node in doc.ChildNodes)
                if (node.Name == "Pakets")
                    paketNode = node;
            Logging.Log("Repository contains {0} pakets", paketNode.ChildNodes.Count);
            Logging.Log("Deleting old Pakets");
            Pakets.Clear();
            Logging.Log("Gathering pakets...");
            foreach (XmlNode node in paketNode)
                if(node.Name == "Paket")
                    Pakets.Add(new Paket(node));
            Logging.Log("Finished updating");
        }

        public Image GetImageFromPaket(Paket p)
        {
            return Image.FromStream(new WebClient().OpenRead(BuildUrl() + p.Folder + "/" + p.Image));
        }

        public Paket GetPaket(string paketName)
        {
            foreach (Paket p in Pakets)
                if (p.Name == paketName)
                    return p;
            throw new PaketNotFoundException(paketName);
        }
    }
}
