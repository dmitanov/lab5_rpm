using lab5_rpm.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_rpm.Adapters
{
    public class LocalFileSystemAdapter : FileSystemAdapterBase
    {
        public LocalFileSystemAdapter(Folder root) : base(root) { }
    }
}
