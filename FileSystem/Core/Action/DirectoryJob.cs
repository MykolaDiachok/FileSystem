using System;
using FileSystem.Core.Base;
using Microsoft.Extensions.Logging;

namespace FileSystem.Core.Action
{
    public class DirectoryJob:IDirectoryJob
    {
        private readonly ILogger<DirectoryJob> _logger;

        public DirectoryJob(ILogger<DirectoryJob> logger)
        {
            _logger = logger;
        }
        public void AddDirectory(string name, Guid directoryId, Category category, Guid parentDirectoryId)
        {
            throw new NotImplementedException();
        }

        public void AddDirectory(string name, Guid directoryId, Category category, Directory parentDirectory)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(Guid directoryId)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(Directory directory)
        {
            throw new NotImplementedException();
        }
    }
}
