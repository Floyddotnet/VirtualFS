using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualFS.Core;
using VirtualFS.FileSystemProvider;

namespace VirtualFS.Tests
{
    [TestClass]
    public class LocalFileSystemProviderTests
    {
        [TestMethod]
        public void GetBytes()
        {
            var lfss = new LocalFileSystemProvider.LocalFileSystemProviderSettings();
            lfss.BasePath = @"c:\temp\LocalFileSystemProviderTestsDir\";
            var lfs = new LocalFileSystemProvider(lfss);
            VirtualFS.Core.VirtualFsHost.MountDrive("local", lfs);

            var r = VDictionary.ReadAllBytes(@"local:\test.txt");
            Assert.IsNotNull(r);
        }
    }
}
