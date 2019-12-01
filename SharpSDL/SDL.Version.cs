using System;
using System.Runtime.InteropServices;

namespace SharpSDL
{
    public static unsafe partial class SDL
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Version
        {
            public const int SizeInBytes = 3;
            public byte Major;
            public byte Minor;
            public byte Patch;
        }

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetVersion(Version* version);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GetRevision();

        public static string GetRevisionString()
        {
            return GetString(GetRevision());
        }

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetRevisionNumber();
    }
}
