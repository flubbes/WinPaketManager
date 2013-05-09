﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RepositoryAdmin
{
    public class Packet
    {
        public Packet(XmlNode node)
        {
            this.Name = node.Attributes["Name"].InnerText;
            this.Version = node.Attributes["Version"].InnerText;
            this.Folder = node.Attributes["Folder"].InnerText;
            this.Category = node.Attributes["Category"].InnerText;
            this.File32 = node.Attributes["File32"].InnerText;
            this.File64 = node.Attributes["File64"].InnerText;
            this.Image = node.Attributes["Image"].InnerText;
        }

        public Packet(string name, string version, string folder, string file32, string file64, string image)
        {
            this.Name = name;
            this.Version = version;
            this.Folder = folder;
            this.File32 = file32;
            this.File64 = file64;
            this.Image = image;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Version
        {
            get;
            private set;
        }

        public string Folder
        {
            get;
            private set;
        }

        public string Category
        {
            get;
            private set;
        }

        public string File32
        {
            get;
            private set;
        }

        public string File64
        {
            get;
            private set;
        }

        public string Image
        {
            get;
            private set;
        }
    }
}
