using lab5_rpm.Core;
using System;
using System.Collections.Generic;
using System.Text;



namespace lab5_rpm.Adapters
{
    public class CloudFileSystemAdapter : FileSystemAdapterBase
    {
        public CloudFileSystemAdapter(Folder root) : base(root) { }
    }
}
