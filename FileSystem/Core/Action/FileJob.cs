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

        public FileJob(ILogger<FileJob> logger)
        {
            _logger = logger;
        }
        public void AddFile(string name, Guid fileId, Category category, Guid parentDirectoryId)
        {
            throw new NotImplementedException();
        }

        public void AddFile(string name, Guid fileId, Category category, Directory parentDirectory)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(Guid fileId)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(File file)
        {
            throw new NotImplementedException();
        }
    }
}
