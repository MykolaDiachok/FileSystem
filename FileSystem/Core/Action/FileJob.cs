using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileSystem.Core.Base;
using Microsoft.Extensions.Logging;

namespace FileSystem.Core.Action
{
    public class FileJob:IFileJob
    {
        private readonly ILogger<FileJob> _logger;
        private readonly IFileSystem<IFile, IDirectory> _fileSystem;

        public FileJob(IFileSystem<IFile,IDirectory> fileSystem, ILogger<FileJob> logger)
        {
            _logger = logger;
            _fileSystem = fileSystem;
        }
        public bool AddFile(string name, Guid fileId, string category, Guid parentDirectoryId)
        {
            throw new NotImplementedException();
        }

        public bool AddFile(string name, Guid fileId, string category, Directory parentDirectory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFile(Guid fileId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFile(File file)
        {
            throw new NotImplementedException();
        }
    }
}
