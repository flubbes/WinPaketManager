using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager.Lib.Managers
{
    public static class RepositoryManager
    {
        public static void Init()
        {
            Categories = new List<string>();
            Repositories = new List<Repository>();
        }

        public static List<Repository> Repositories
        {
            get;
            private set;
        }

        public static void Update()
        {
            foreach (Repository rep in Repositories)
            {
                try
                {
                    rep.Update();
                }
                catch (Exception ex)
                {
                    Logging.Log("{0}: {1}", ex.GetType(), ex.Message);
                }
                foreach (Packet p in rep.Packets)
                {
                    AddCategory(p.Category);
                    Logging.Log("Added {0}", p.Name);
                }
            }
        }

        public static Packet[] GetPacketsFromCategory(string catName)
        {
            List<Packet> result = new List<Packet>();
            foreach (Repository rep in Repositories)
                foreach (Packet p in rep.Packets)
                    if (p.Category == catName)
                        result.Add(p);
            return result.ToArray();
        }

        public static Packet GetPacketByName(string name)
        {
            foreach (Repository rep in Repositories)
                foreach (Packet p in rep.Packets)
                    if (p.Name == name) return p;
            Logging.Log("Packet {0} not found", name);
            return null;
        }

        public static void AddRepository(Repository rep)
        {
            Repositories.Add(rep);
        }

        public static void AddCategory(string cat)
        {
            foreach (string catName in Categories)
                if (catName == cat)
                    return;
            Categories.Add(cat);
            Categories.Sort();
        }

        public static List<string> Categories
        {
            get;
            private set;
        }
    }
}
