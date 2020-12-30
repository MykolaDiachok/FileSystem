using FileSystem.Core.Base;

namespace FileSystem.Core.Action
{
    public interface IFileSystemJob
    {
        IFileSystem<IFile, IDirectory> ShowAll();
    }
}
