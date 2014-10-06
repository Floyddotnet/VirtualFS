using System;
using System.Security.Cryptography.X509Certificates;

namespace VirtualFS.Core
{
    public interface IFileSystemProvider : IDisposable
    {
        byte[] ReadAllBytes(string filepath);
    }
}