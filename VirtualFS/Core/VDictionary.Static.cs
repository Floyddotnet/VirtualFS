using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFS.Core
{
    
    public partial class VDictionary
    {
        public static byte[] ReadAllBytes(string filepath)
        {
            var driveName = VPath.GetDriveName(filepath);
            var fsp = VirtualFsHost.GetFileSystemProviderByDriveName(driveName);
            return fsp.ReadAllBytes(filepath);
        }
    }
}
