using System;

namespace FileSystem.Core.Base
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
