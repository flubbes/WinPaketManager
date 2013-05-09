using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WinPacketManager.Lib.Exceptions;
using WinPacketManager.Lib.Managers;

namespace WinPacketManager.Lib.Objects
{
    public class Repository
    {
        const string repositoryIndex = "index.html";

        public Repository(string address)
        {
            this.Address = address;
            this.Packets = new List<Packet>();
        }

        public string Address
        {
            get;
            private set;
        }

        public List<Packet> Packets
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
                if (node.Name == "Packets")
                    paketNode = node;
            Logging.Log("Repository contains {0} pakets", paketNode.ChildNodes.Count);
            Logging.Log("Deleting old Packets");
            Packets.Clear();
            Logging.Log("Gathering pakets...");
            foreach (XmlNode node in paketNode)
                if(node.Name == "Packet")
                    Packets.Add(new Packet(node,this));
            Logging.Log("Finished updating");
        }

        public Image GetImageFromPacket(Packet p)
        {
            Logging.Log("Reading image stream from {0}", p.Name);
            return Image.FromStream(new WebClient().OpenRead(BuildUrl() + p.Folder + "/" + p.Image));
        }

        public Packet GetPacket(string paketName)
        {
            foreach (Packet p in Packets)
                if (p.Name == paketName)
                    return p;
            throw new PacketNotFoundException(paketName);
        }
    }
}
