using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAdmin
{
    class Repository
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public RepositoryFolderType Type {get; set;}

        public Repository(string name, string path, RepositoryFolderType type)
        {
            this.Name = name;
            this.Path = path;
            this.Type = type;
        }
    }
}
