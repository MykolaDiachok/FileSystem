using System;
using FileSystem.Core.Base;
using Microsoft.Extensions.Logging;

namespace FileSystem.Core.Action
{
    public class DirectoryJob:IDirectoryJob
    {
        private readonly IFileSystem<IFile, IDirectory> _fileSystem;
        private readonly ILogger<DirectoryJob> _logger;

        public DirectoryJob(IFileSystem<IFile,IDirectory> fileSystem,ILogger<DirectoryJob> logger)
        {
            _fileSystem = fileSystem;
            _logger = logger;
        }
        public bool AddDirectory(string name, Guid directoryId, string category, Guid parentDirectoryId)
        {
            throw new NotImplementedException();
        }

        public bool AddDirectory(string name, Guid directoryId, string category, Directory parentDirectory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDirectory(Guid directoryId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDirectory(Directory directory)
        {
            throw new NotImplementedException();
        }
    }
}
