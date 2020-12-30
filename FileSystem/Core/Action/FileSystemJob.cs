using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileSystem.Core.Base;
using Microsoft.Extensions.Logging;

namespace FileSystem.Core.Action
{
    public class FileSystemJob:IFileSystemJob
    {
        private readonly IFileSystem<IFile, IDirectory> _fileSystem;
        private readonly ILogger<FileSystemJob> _logger;

        public FileSystemJob(IFileSystem<IFile,IDirectory> fileSystem, ILogger<FileSystemJob> logger)
        {
            _fileSystem = fileSystem;
            _logger = logger;
        }
        public IFileSystem<IFile, IDirectory> ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
