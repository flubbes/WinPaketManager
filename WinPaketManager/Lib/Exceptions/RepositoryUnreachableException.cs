using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinPaketManager.Lib.Objects;

namespace WinPaketManager.Lib.Exceptions
{
    public class RepositoryUnreachableException : Exception
    {
        public RepositoryUnreachableException(Repository rep)
        {
            this.Repository = rep;
        }

        public Repository Repository
        {
            get;
            private set;
        }
    }
}
