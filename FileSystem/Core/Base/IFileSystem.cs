using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSystem.Core.Base
{
    public interface IFileSystem<TF, TD>
    {
        TF Data { get; }
        TD Parent { get; }
        IList<IFileSystem<TF, TD>> Children { get; }
        bool IsRoot { get; }
    }
}
