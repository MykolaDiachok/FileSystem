using System;
using FileSystem.Core.Base;

namespace FileSystem.Core.Action
{
    public interface IFileJob
    {
        bool AddFile(string name, Guid fileId, string category, Guid parentDirectoryId);
        bool AddFile(string name, Guid fileId, string category, Directory parentDirectory);
        bool DeleteFile(Guid fileId);
        bool DeleteFile(File file);
    }
}
