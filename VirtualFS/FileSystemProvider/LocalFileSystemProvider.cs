using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VirtualFS.Core;

namespace VirtualFS.FileSystemProvider
{
    public class LocalFileSystemProvider : IFileSystemProvider
    {
        private LocalFileSystemProviderSettings Settings{get;set;}

        public LocalFileSystemProvider(LocalFileSystemProviderSettings settings)
        {
            Settings = settings;
        }

        public void Dispose(){}

        public byte[] ReadAllBytes(string filepath)
        {
            if (Settings.DownstreamProvider != null)
                return Settings.DownstreamProvider.ReadAllBytes(filepath);

            var pathPart = VPath.GetPathPart(filepath);
            var fullPath = Path.Combine(Settings.BasePath, pathPart);
            return File.ReadAllBytes(fullPath);
        }

        public class LocalFileSystemProviderSettings : IFileSystemProviderSettings
        {
            public string BasePath { get; set; }
            public IFileSystemProvider DownstreamProvider { get; set; }
        }
    }
}
