using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSystem.Core.Base
{
    public interface IDirectory:IFile
    {
        bool IsDirectory { get;  }
    }
}
