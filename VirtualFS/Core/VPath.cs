using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFS.Core
{
    public static class VPath
    {
        private const string DriveNameDelimiter = @":/";
        public static string GetDriveName(string path)
        {
            if (!path.Contains(DriveNameDelimiter)) throw new DriveNameUnkownException(string.Format("Path: '{0}'", path));
            return path.Split(new string[] { DriveNameDelimiter }, StringSplitOptions.None)[0];
        }

        public static string GetPathPart(string path)
        {
            if (!path.Contains(DriveNameDelimiter)) throw new DriveNameUnkownException(string.Format("Path: '{0}'", path));

            return path.Split(new string[] { DriveNameDelimiter }, StringSplitOptions.None)[1];
        }

    }
}
