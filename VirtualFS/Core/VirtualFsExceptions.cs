using System;

namespace VirtualFS.Core
{
    public abstract class VirtualFsException : Exception
    {
        internal protected VirtualFsException() { }
        internal protected VirtualFsException(string message) : base(message) { }
        internal protected VirtualFsException(string message, Exception inner) : base(message, inner) { }
    }

    public class DriveNameAlreadyAssignedException : VirtualFsException
    {
        internal protected DriveNameAlreadyAssignedException() { }
        internal protected DriveNameAlreadyAssignedException(string message) : base(message) { }
        internal protected DriveNameAlreadyAssignedException(string message, Exception inner) : base(message, inner) { }
    }

    public class DriveNameUnkownException : VirtualFsException
    {
        internal protected DriveNameUnkownException() { }
        internal protected DriveNameUnkownException(string message) : base(message) { }
        internal protected DriveNameUnkownException(string message, Exception inner) : base(message, inner) { }
    }
}