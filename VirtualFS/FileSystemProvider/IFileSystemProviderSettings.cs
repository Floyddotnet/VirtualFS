using VirtualFS.Core;

namespace VirtualFS.FileSystemProvider
{
    internal interface IFileSystemProviderSettings
    {
        IFileSystemProvider UpstreamProvider { get; set; }
    }
}