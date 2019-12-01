using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpSDL
{
    public static unsafe partial class SDL
    {
        [Flags]
        public enum InitFlags : uint
        {
            None = 0,
            Timer = 0x00000001u,
            Audio = 0x00000010u,
            Video = 0x00000020u,
            Joystick = 0x00000200u,
            Haptic = 0x00001000u,
            GameController = 0x00002000u,
            Events = 0x00004000u,
            NoParachute = 0x00100000u,
            Everything = Timer | Audio | Video | Events
                | Joystick | Haptic | GameController
        }

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Init(InitFlags flags);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitSubSystem(InitFlags flags);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QuitSubSystem(InitFlags flags);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern InitFlags WasInit(InitFlags flags);

        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Quit();

        private static string GetString(byte* ptr)
        {
            int count = 0;
            while (*(ptr + count) != 0)
            {
                count += 1;
            }

            return Encoding.UTF8.GetString(ptr, count);
        }
    }
}
