using VirtualFS.Core;

namespace VirtualFS.FileSystemProvider
{
    internal interface IFileSystemProviderSettings
    {
        IFileSystemProvider DownstreamProvider { get; set; }
    }
}