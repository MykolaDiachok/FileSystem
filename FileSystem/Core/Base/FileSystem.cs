using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace FileSystem.Core.Base
{
    public class FileSystem:IFileSystem<IFile, IDirectory>
    {
        private readonly ILogger<FileSystem> _logger;


        public FileSystem(IFile data, IDirectory parent, bool isRoot, ILogger<FileSystem> logger)
        {
            _logger = logger;
            Data = data;
            Parent = parent;
            if (data is IDirectory)
                Children = new List<IFileSystem<IFile, IDirectory>>();
            IsRoot = isRoot;
        }

        public FileSystem(IFile data, IDirectory parent, ILogger<FileSystem> logger)
        {
            _logger = logger;
            Data = data;
            Parent = parent;
            if (data is IDirectory)
                Children = new List<IFileSystem<IFile, IDirectory>>();
            IsRoot = false;
        }

        public IFile Data { get; }
        public IDirectory Parent { get; }
        public IList<IFileSystem<IFile, IDirectory>> Children { get; }
        public bool IsRoot { get; }
    }
}
