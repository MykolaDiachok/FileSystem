using System;
using FileSystem.Core.Base;

namespace FileSystem.Core.Action
{
    public interface IDirectoryJob
    {
        bool AddDirectory(string name, Guid directoryId, string category, Guid parentDirectoryId);
        bool AddDirectory(string name, Guid directoryId, string category, Directory parentDirectory);
        bool DeleteDirectory(Guid directoryId);
        bool DeleteDirectory(Directory directory);

    }
}
