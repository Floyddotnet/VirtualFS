using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFS.Core
{
    
    public partial class VDictionary
    {
        public byte[] GetBytes(string filename)
        {
            var driveName = VPath.GetDriveName(filename);
            var fsp = VirtualFsHost.GetFileSystemProviderByDriveName(driveName);
            return 
        }
    }
}
