using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSystem.Core.Base
{
    public interface IFile
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        Guid ParentDirectoryId { get; set; } 
        bool Deleted { get; set; }

        bool IsDirectory { get; }
    }
}
