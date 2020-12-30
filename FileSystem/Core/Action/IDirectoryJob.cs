using System;
using FileSystem.Core.Base;

namespace FileSystem.Core.Action
{
    internal interface IDirectoryJob
    {
        void AddDirectory(string name, Guid directoryId, Category category, Guid parentDirectoryId);
        void AddDirectory(string name, Guid directoryId, Category category, Directory parentDirectory);
        void DeleteDirectory(Guid directoryId);
        void DeleteDirectory(Directory directory);

    }
}
