using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualFS.Core;

namespace VirtualFS.FileSystemProvider
{
    class LocalFileSystemProvider : IFileSystemProvider
    {
        private LocalFileSystemProviderSettings Settings{get;set;}

        public LocalFileSystemProvider(LocalFileSystemProviderSettings settings)
        {
            Settings = settings;
        }

        public void Dispose(){}

        public byte[] GetBytes(string filepath)
        {
            var pathPart = VPath.GetPathPart(filepath);
            var fullPath = Path.Combine(Settings.BasePath, filepath);
            return File.ReadAllBytes(fullPath);
        }

        public class LocalFileSystemProviderSettings
        {
            public string BasePath { get; set; }
        }
    }
}
