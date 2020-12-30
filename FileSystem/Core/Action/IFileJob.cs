using System;
using FileSystem.Core.Base;

namespace FileSystem.Core.Action
{
    internal interface IFileJob
    {
        void AddFile(string name, Guid fileId, Category category, Guid parentDirectoryId);
        void AddFile(string name, Guid fileId, Category category, Directory parentDirectory);
        void DeleteFile(Guid fileId);
        void DeleteFile(File file);
    }
}
