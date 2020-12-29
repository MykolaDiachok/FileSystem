using System;

namespace FileSystem.Core.Base
{
    public class Directory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Directory ParentDirectory { get; set; }
        public bool Deleted { get; set; }
    }
}
