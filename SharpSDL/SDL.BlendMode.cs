using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpSDL
{
    public static unsafe partial class SDL
    {
        public enum SDL_BlendMode
        {
            SDL_BLENDMODE_NONE = 0x00000000,
            SDL_BLENDMODE_BLEND = 0x00000001,
            SDL_BLENDMODE_ADD = 0x00000002,
            SDL_BLENDMODE_MOD = 0x00000004,
            SDL_BLENDMODE_INVALID = 0x7FFFFFFF
        }

        public enum SDL_BlendOperation
        {
            SDL_BLENDOPERATION_ADD = 0x1,
            SDL_BLENDOPERATION_SUBTRACT = 0x2,
            SDL_BLENDOPERATION_REV_SUBTRACT = 0x3,
            SDL_BLENDOPERATION_MINIMUM = 0x4,
            SDL_BLENDOPERATION_MAXIMUM = 0x5
        }

        public enum SDL_BlendFactor
        {
            SDL_BLENDFACTOR_ZERO = 0x1,
            SDL_BLENDFACTOR_ONE = 0x2,
            SDL_BLENDFACTOR_SRC_COLOR = 0x3,
            SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR = 0x4,
            SDL_BLENDFACTOR_SRC_ALPHA = 0x5,
            SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = 0x6,
            SDL_BLENDFACTOR_DST_COLOR = 0x7,
            SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR = 0x8,
            SDL_BLENDFACTOR_DST_ALPHA = 0x9,
            SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA = 0xA
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate SDL_BlendMode SDL_ComposeCustomBlendMode_d(
            SDL_BlendFactor srcColorFactor,
            SDL_BlendFactor dstColorFactor,
            SDL_BlendOperation colorOperation,
            SDL_BlendFactor srcAlphaFactor,
            SDL_BlendFactor dstAlphaFactor,
            SDL_BlendOperation alphaOperation);

        private static SDL_ComposeCustomBlendMode_d SDL_ComposeCustomBlendMode_f;

        public static SDL_BlendMode SDL_ComposeCustomBlendMode(
            SDL_BlendFactor srcColorFactor,
            SDL_BlendFactor dstColorFactor,
            SDL_BlendOperation colorOperation,
            SDL_BlendFactor srcAlphaFactor,
            SDL_BlendFactor dstAlphaFactor,
            SDL_BlendOperation alphaOperation) => SDL_ComposeCustomBlendMode_f(
                srcColorFactor,
                dstColorFactor,
                colorOperation,
                srcAlphaFactor,
                dstAlphaFactor,
                alphaOperation);
    }
}
