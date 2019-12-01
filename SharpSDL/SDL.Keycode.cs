using System;

namespace SharpSDL
{
    public static unsafe partial class SDL
    {
        public const int SDLK_MASK = 1 << 30;

        public enum Keycode
        {
            UNKNOWN = 0,

            RETURN = '\r',
            ESCAPE = 27,
            BACKSPACE = '\b',
            TAB = '\t',
            SPACE = ' ',
            EXCLAIM = '!',
            QUOTEDBL = '"',
            HASH = '#',
            PERCENT = '%',
            DOLLAR = '$',
            AMPERSAND = '&',
            QUOTE = '\'',
            LEFTPAREN = '(',
            RIGHTPAREN = ')',
            ASTERISK = '*',
            PLUS = '+',
            COMMA = ',',
            MINUS = '-',
            PERIOD = '.',
            SLASH = '/',
            N0 = '0',
            N1 = '1',
            N2 = '2',
            N3 = '3',
            N4 = '4',
            N5 = '5',
            N6 = '6',
            N7 = '7',
            N8 = '8',
            N9 = '9',
            COLON = ':',
            SEMICOLON = ';',
            LESS = '<',
            EQUALS = '=',
            GREATER = '>',
            QUESTION = '?',
            AT = '@',
            /*
               Skip uppercase letters
             */
            LEFTBRACKET = '[',
            BACKSLASH = '\\',
            RIGHTBRACKET = ']',
            CARET = '^',
            UNDERSCORE = '_',
            BACKQUOTE = '`',
            a = 'a',
            b = 'b',
            c = 'c',
            d = 'd',
            e = 'e',
            f = 'f',
            g = 'g',
            h = 'h',
            i = 'i',
            j = 'j',
            k = 'k',
            l = 'l',
            m = 'm',
            n = 'n',
            o = 'o',
            p = 'p',
            q = 'q',
            r = 'r',
            s = 's',
            t = 't',
            u = 'u',
            v = 'v',
            w = 'w',
            x = 'x',
            y = 'y',
            z = 'z',

            CAPSLOCK = Scancode.CAPSLOCK | SDLK_MASK,

            F1 = Scancode.F1 | SDLK_MASK,
            F2 = Scancode.F2 | SDLK_MASK,
            F3 = Scancode.F3 | SDLK_MASK,
            F4 = Scancode.F4 | SDLK_MASK,
            F5 = Scancode.F5 | SDLK_MASK,
            F6 = Scancode.F6 | SDLK_MASK,
            F7 = Scancode.F7 | SDLK_MASK,
            F8 = Scancode.F8 | SDLK_MASK,
            F9 = Scancode.F9 | SDLK_MASK,
            F10 = Scancode.F10 | SDLK_MASK,
            F11 = Scancode.F11 | SDLK_MASK,
            F12 = Scancode.F12 | SDLK_MASK,

            PRINTSCREEN = Scancode.PRINTSCREEN | SDLK_MASK,
            SCROLLLOCK = Scancode.SCROLLLOCK | SDLK_MASK,
            PAUSE = Scancode.PAUSE | SDLK_MASK,
            INSERT = Scancode.INSERT | SDLK_MASK,
            HOME = Scancode.HOME | SDLK_MASK,
            PAGEUP = Scancode.PAGEUP | SDLK_MASK,
            DELETE = 127,
            END = Scancode.END | SDLK_MASK,
            PAGEDOWN = Scancode.PAGEDOWN | SDLK_MASK,
            RIGHT = Scancode.RIGHT | SDLK_MASK,
            LEFT = Scancode.LEFT | SDLK_MASK,
            DOWN = Scancode.DOWN | SDLK_MASK,
            UP = Scancode.UP | SDLK_MASK,

            NUMLOCKCLEAR = Scancode.NUMLOCKCLEAR | SDLK_MASK,
            KP_DIVIDE = Scancode.KP_DIVIDE | SDLK_MASK,
            KP_MULTIPLY = Scancode.KP_MULTIPLY | SDLK_MASK,
            KP_MINUS = Scancode.KP_MINUS | SDLK_MASK,
            KP_PLUS = Scancode.KP_PLUS | SDLK_MASK,
            KP_ENTER = Scancode.KP_ENTER | SDLK_MASK,
            KP_1 = Scancode.KP_1 | SDLK_MASK,
            KP_2 = Scancode.KP_2 | SDLK_MASK,
            KP_3 = Scancode.KP_3 | SDLK_MASK,
            KP_4 = Scancode.KP_4 | SDLK_MASK,
            KP_5 = Scancode.KP_5 | SDLK_MASK,
            KP_6 = Scancode.KP_6 | SDLK_MASK,
            KP_7 = Scancode.KP_7 | SDLK_MASK,
            KP_8 = Scancode.KP_8 | SDLK_MASK,
            KP_9 = Scancode.KP_9 | SDLK_MASK,
            KP_0 = Scancode.KP_0 | SDLK_MASK,
            KP_PERIOD = Scancode.KP_PERIOD | SDLK_MASK,

            APPLICATION = Scancode.APPLICATION | SDLK_MASK,
            POWER = Scancode.POWER | SDLK_MASK,
            KP_EQUALS = Scancode.KP_EQUALS | SDLK_MASK,
            F13 = Scancode.F13 | SDLK_MASK,
            F14 = Scancode.F14 | SDLK_MASK,
            F15 = Scancode.F15 | SDLK_MASK,
            F16 = Scancode.F16 | SDLK_MASK,
            F17 = Scancode.F17 | SDLK_MASK,
            F18 = Scancode.F18 | SDLK_MASK,
            F19 = Scancode.F19 | SDLK_MASK,
            F20 = Scancode.F20 | SDLK_MASK,
            F21 = Scancode.F21 | SDLK_MASK,
            F22 = Scancode.F22 | SDLK_MASK,
            F23 = Scancode.F23 | SDLK_MASK,
            F24 = Scancode.F24 | SDLK_MASK,
            EXECUTE = Scancode.EXECUTE | SDLK_MASK,
            HELP = Scancode.HELP | SDLK_MASK,
            MENU = Scancode.MENU | SDLK_MASK,
            SELECT = Scancode.SELECT | SDLK_MASK,
            STOP = Scancode.STOP | SDLK_MASK,
            AGAIN = Scancode.AGAIN | SDLK_MASK,
            UNDO = Scancode.UNDO | SDLK_MASK,
            CUT = Scancode.CUT | SDLK_MASK,
            COPY = Scancode.COPY | SDLK_MASK,
            PASTE = Scancode.PASTE | SDLK_MASK,
            FIND = Scancode.FIND | SDLK_MASK,
            MUTE = Scancode.MUTE | SDLK_MASK,
            VOLUMEUP = Scancode.VOLUMEUP | SDLK_MASK,
            VOLUMEDOWN = Scancode.VOLUMEDOWN | SDLK_MASK,
            KP_COMMA = Scancode.KP_COMMA | SDLK_MASK,
            KP_EQUALSAS400 = Scancode.KP_EQUALSAS400 | SDLK_MASK,

            ALTERASE = Scancode.ALTERASE | SDLK_MASK,
            SYSREQ = Scancode.SYSREQ | SDLK_MASK,
            CANCEL = Scancode.CANCEL | SDLK_MASK,
            CLEAR = Scancode.CLEAR | SDLK_MASK,
            PRIOR = Scancode.PRIOR | SDLK_MASK,
            RETURN2 = Scancode.RETURN2 | SDLK_MASK,
            SEPARATOR = Scancode.SEPARATOR | SDLK_MASK,
            OUT = Scancode.OUT | SDLK_MASK,
            OPER = Scancode.OPER | SDLK_MASK,
            CLEARAGAIN = Scancode.CLEARAGAIN | SDLK_MASK,
            CRSEL = Scancode.CRSEL | SDLK_MASK,
            EXSEL = Scancode.EXSEL | SDLK_MASK,

            KP_00 = Scancode.KP_00 | SDLK_MASK,
            KP_000 = Scancode.KP_000 | SDLK_MASK,
            THOUSANDSSEPARATOR = Scancode.THOUSANDSSEPARATOR | SDLK_MASK,
            DECIMALSEPARATOR = Scancode.DECIMALSEPARATOR | SDLK_MASK,
            CURRENCYUNIT = Scancode.CURRENCYUNIT | SDLK_MASK,
            CURRENCYSUBUNIT = Scancode.CURRENCYSUBUNIT | SDLK_MASK,
            KP_LEFTPAREN = Scancode.KP_LEFTPAREN | SDLK_MASK,
            KP_RIGHTPAREN = Scancode.KP_RIGHTPAREN | SDLK_MASK,
            KP_LEFTBRACE = Scancode.KP_LEFTBRACE | SDLK_MASK,
            KP_RIGHTBRACE = Scancode.KP_RIGHTBRACE | SDLK_MASK,
            KP_TAB = Scancode.KP_TAB | SDLK_MASK,
            KP_BACKSPACE = Scancode.KP_BACKSPACE | SDLK_MASK,
            KP_A = Scancode.KP_A | SDLK_MASK,
            KP_B = Scancode.KP_B | SDLK_MASK,
            KP_C = Scancode.KP_C | SDLK_MASK,
            KP_D = Scancode.KP_D | SDLK_MASK,
            KP_E = Scancode.KP_E | SDLK_MASK,
            KP_F = Scancode.KP_F | SDLK_MASK,
            KP_XOR = Scancode.KP_XOR | SDLK_MASK,
            KP_POWER = Scancode.KP_POWER | SDLK_MASK,
            KP_PERCENT = Scancode.KP_PERCENT | SDLK_MASK,
            KP_LESS = Scancode.KP_LESS | SDLK_MASK,
            KP_GREATER = Scancode.KP_GREATER | SDLK_MASK,
            KP_AMPERSAND = Scancode.KP_AMPERSAND | SDLK_MASK,
            KP_DBLAMPERSAND = Scancode.KP_DBLAMPERSAND | SDLK_MASK,
            KP_VERTICALBAR = Scancode.KP_VERTICALBAR | SDLK_MASK,
            KP_DBLVERTICALBAR = Scancode.KP_DBLVERTICALBAR | SDLK_MASK,
            KP_COLON = Scancode.KP_COLON | SDLK_MASK,
            KP_HASH = Scancode.KP_HASH | SDLK_MASK,
            KP_SPACE = Scancode.KP_SPACE | SDLK_MASK,
            KP_AT = Scancode.KP_AT | SDLK_MASK,
            KP_EXCLAM = Scancode.KP_EXCLAM | SDLK_MASK,
            KP_MEMSTORE = Scancode.KP_MEMSTORE | SDLK_MASK,
            KP_MEMRECALL = Scancode.KP_MEMRECALL | SDLK_MASK,
            KP_MEMCLEAR = Scancode.KP_MEMCLEAR | SDLK_MASK,
            KP_MEMADD = Scancode.KP_MEMADD | SDLK_MASK,
            KP_MEMSUBTRACT = Scancode.KP_MEMSUBTRACT | SDLK_MASK,
            KP_MEMMULTIPLY = Scancode.KP_MEMMULTIPLY | SDLK_MASK,
            KP_MEMDIVIDE = Scancode.KP_MEMDIVIDE | SDLK_MASK,
            KP_PLUSMINUS = Scancode.KP_PLUSMINUS | SDLK_MASK,
            KP_CLEAR = Scancode.KP_CLEAR | SDLK_MASK,
            KP_CLEARENTRY = Scancode.KP_CLEARENTRY | SDLK_MASK,
            KP_BINARY = Scancode.KP_BINARY | SDLK_MASK,
            KP_OCTAL = Scancode.KP_OCTAL | SDLK_MASK,
            KP_DECIMAL = Scancode.KP_DECIMAL | SDLK_MASK,
            KP_HEXADECIMAL = Scancode.KP_HEXADECIMAL | SDLK_MASK,

            LCTRL = Scancode.LCTRL | SDLK_MASK,
            LSHIFT = Scancode.LSHIFT | SDLK_MASK,
            LALT = Scancode.LALT | SDLK_MASK,
            LGUI = Scancode.LGUI | SDLK_MASK,
            RCTRL = Scancode.RCTRL | SDLK_MASK,
            RSHIFT = Scancode.RSHIFT | SDLK_MASK,
            RALT = Scancode.RALT | SDLK_MASK,
            RGUI = Scancode.RGUI | SDLK_MASK,

            MODE = Scancode.MODE | SDLK_MASK,

            AUDIONEXT = Scancode.AUDIONEXT | SDLK_MASK,
            AUDIOPREV = Scancode.AUDIOPREV | SDLK_MASK,
            AUDIOSTOP = Scancode.AUDIOSTOP | SDLK_MASK,
            AUDIOPLAY = Scancode.AUDIOPLAY | SDLK_MASK,
            AUDIOMUTE = Scancode.AUDIOMUTE | SDLK_MASK,
            MEDIASELECT = Scancode.MEDIASELECT | SDLK_MASK,
            WWW = Scancode.WWW | SDLK_MASK,
            MAIL = Scancode.MAIL | SDLK_MASK,
            CALCULATOR = Scancode.CALCULATOR | SDLK_MASK,
            COMPUTER = Scancode.COMPUTER | SDLK_MASK,
            AC_SEARCH = Scancode.AC_SEARCH | SDLK_MASK,
            AC_HOME = Scancode.AC_HOME | SDLK_MASK,
            AC_BACK = Scancode.AC_BACK | SDLK_MASK,
            AC_FORWARD = Scancode.AC_FORWARD | SDLK_MASK,
            AC_STOP = Scancode.AC_STOP | SDLK_MASK,
            AC_REFRESH = Scancode.AC_REFRESH | SDLK_MASK,
            AC_BOOKMARKS = Scancode.AC_BOOKMARKS | SDLK_MASK,

            BRIGHTNESSDOWN = Scancode.BRIGHTNESSDOWN | SDLK_MASK,
            BRIGHTNESSUP = Scancode.BRIGHTNESSUP | SDLK_MASK,
            DISPLAYSWITCH = Scancode.DISPLAYSWITCH | SDLK_MASK,
            KBDILLUMTOGGLE = Scancode.KBDILLUMTOGGLE | SDLK_MASK,
            KBDILLUMDOWN = Scancode.KBDILLUMDOWN | SDLK_MASK,
            KBDILLUMUP = Scancode.KBDILLUMUP | SDLK_MASK,
            EJECT = Scancode.EJECT | SDLK_MASK,
            SLEEP = Scancode.SLEEP | SDLK_MASK,
            APP1 = Scancode.APP1 | SDLK_MASK,
            APP2 = Scancode.APP2 | SDLK_MASK,

            AUDIOREWIND = Scancode.AUDIOREWIND | SDLK_MASK,
            AUDIOFASTFORWARD = Scancode.AUDIOFASTFORWARD | SDLK_MASK
        }

        [Flags]
        public enum KeyModifier : ushort
        {
            None = 0x0000,
            LeftShift = 0x0001,
            RightShift = 0x0002,
            LeftCtrl = 0x0040,
            RightCtrl = 0x0080,
            LeftAlt = 0x0100,
            RightAlt = 0x0200,
            LeftGui = 0x0400,
            RightGui = 0x0800,
            Num = 0x1000,
            Caps = 0x2000,
            Mode = 0x4000,
            Reserved = 0x8000,

            Ctrl = LeftCtrl | RightCtrl,
            Shift = LeftShift | RightShift,
            Alt = LeftAlt | RightAlt,
            Gui = LeftGui | RightGui
        }
    }
}
