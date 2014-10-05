using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VirtualFS.Core
{
    public partial class VirtualFsHost
    {
        private static readonly ConcurrentDictionary<string, IFileSystemProvider> Drives = new ConcurrentDictionary<string, IFileSystemProvider>(StringComparer.InvariantCultureIgnoreCase);

        private static readonly object MountDriveLock = new object();
        public static void MountDrive(string driveName, IFileSystemProvider fileSystemProvider)
        {
            lock (MountDriveLock)
            {
                if (Drives.ContainsKey(driveName)) throw new DriveNameAlreadyAssignedException();
                Drives.TryAdd(driveName, fileSystemProvider);
            }
        }

        public static void UnMountDrive(string driveName)
        {
            UnMountDrive(driveName, false);
        }
        public static void UnMountDrive(string driveName, bool disposeFileSystemProvider)
        {
            lock (MountDriveLock)
            {
                if (Drives.ContainsKey(driveName)) throw new DriveNameUnkownException();

                IFileSystemProvider fs;
                Drives.TryRemove(driveName, out fs);

                if(disposeFileSystemProvider)
                    fs.Dispose();
            }
        }

        
    }
}
