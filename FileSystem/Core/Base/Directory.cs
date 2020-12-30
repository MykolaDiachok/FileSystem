using System;

namespace FileSystem.Core.Base
{
    public class Directory:IDirectory,IFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Guid ParentDirectoryId { get; set; }
        public bool Deleted { get; set; }
        public bool IsDirectory { get; } = true;
    }
}
