using NativeLibraryLoader;

namespace SharpSDL
{
    public static partial class SDL
    {
        private static NativeLibrary library;

        public static void LoadLibrary(string name = "SDL2")
        {
            library?.Dispose();
            library = new NativeLibrary(name);

            SDL_AddEventWatch_f = library.LoadFunction<SDL_AddEventWatch_d>(nameof(SDL_AddEventWatch));
            SDL_AllocFormat_f = library.LoadFunction<SDL_AllocFormat_d>(nameof(SDL_AllocFormat));
            SDL_AllocPalette_f = library.LoadFunction<SDL_AllocPalette_d>(nameof(SDL_AllocPalette));
            SDL_CalculateGammaRamp_f = library.LoadFunction<SDL_CalculateGammaRamp_d>(nameof(SDL_CalculateGammaRamp));
            SDL_CaptureMouse_f = library.LoadFunction<SDL_CaptureMouse_d>(nameof(SDL_CaptureMouse));
            SDL_ClearError_f = library.LoadFunction<SDL_ClearError_d>(nameof(SDL_ClearError));
            SDL_ComposeCustomBlendMode_f = library.LoadFunction<SDL_ComposeCustomBlendMode_d>(nameof(SDL_ComposeCustomBlendMode));
            SDL_ConvertPixels_f = library.LoadFunction<SDL_ConvertPixels_d>(nameof(SDL_ConvertPixels));
            SDL_ConvertSurface_f = library.LoadFunction<SDL_ConvertSurface_d>(nameof(SDL_ConvertSurface));
            SDL_ConvertSurfaceFormat_f = library.LoadFunction<SDL_ConvertSurfaceFormat_d>(nameof(SDL_ConvertSurfaceFormat));
            SDL_CreateCursor_f = library.LoadFunction<SDL_CreateCursor_d>(nameof(SDL_CreateCursor));
            SDL_CreateRenderer_f = library.LoadFunction<SDL_CreateRenderer_d>(nameof(SDL_CreateRenderer));
            SDL_CreateRGBSurface_f = library.LoadFunction<SDL_CreateRGBSurface_d>(nameof(SDL_CreateRGBSurface));
            SDL_CreateRGBSurfaceFrom_f = library.LoadFunction<SDL_CreateRGBSurfaceFrom_d>(nameof(SDL_CreateRGBSurfaceFrom));
            SDL_CreateRGBSurfaceWithFormatFrom_f = library.LoadFunction<SDL_CreateRGBSurfaceWithFormatFrom_d>(nameof(SDL_CreateRGBSurfaceWithFormatFrom));
            SDL_CreateRGBSurfaceWithFormat_f = library.LoadFunction<SDL_CreateRGBSurfaceWithFormat_d>(nameof(SDL_CreateRGBSurfaceWithFormat));
            SDL_CreateSoftwareRenderer_f = library.LoadFunction<SDL_CreateSoftwareRenderer_d>(nameof(SDL_CreateSoftwareRenderer));
            SDL_CreateSystemCursor_f = library.LoadFunction<SDL_CreateSystemCursor_d>(nameof(SDL_CreateSystemCursor));
            SDL_CreateTexture_f = library.LoadFunction<SDL_CreateTexture_d>(nameof(SDL_CreateTexture));
            SDL_CreateTextureFromSurface_f = library.LoadFunction<SDL_CreateTextureFromSurface_d>(nameof(SDL_CreateTextureFromSurface));
            SDL_CreateWindow_f = library.LoadFunction<SDL_CreateWindow_d>(nameof(SDL_CreateWindow));
            SDL_CreateWindowAndRenderer_f = library.LoadFunction<SDL_CreateWindowAndRenderer_d>(nameof(SDL_CreateWindowAndRenderer));
            SDL_CreateWindowFrom_f = library.LoadFunction<SDL_CreateWindowFrom_d>(nameof(SDL_CreateWindowFrom));
            SDL_DelEventWatch_f = library.LoadFunction<SDL_DelEventWatch_d>(nameof(SDL_DelEventWatch));
            SDL_DestroyRenderer_f = library.LoadFunction<SDL_DestroyRenderer_d>(nameof(SDL_DestroyRenderer));
            SDL_DestroyTexture_f = library.LoadFunction<SDL_DestroyTexture_d>(nameof(SDL_DestroyTexture));
            SDL_DestroyWindow_f = library.LoadFunction<SDL_DestroyWindow_d>(nameof(SDL_DestroyWindow));
            SDL_DisableScreenSaver_f = library.LoadFunction<SDL_DisableScreenSaver_d>(nameof(SDL_DisableScreenSaver));
            SDL_EnableScreenSaver_f = library.LoadFunction<SDL_EnableScreenSaver_d>(nameof(SDL_EnableScreenSaver));
            SDL_EventState_f = library.LoadFunction<SDL_EventState_d>(nameof(SDL_EventState));
            SDL_FillRect_f = library.LoadFunction<SDL_FillRect_d>(nameof(SDL_FillRect));
            SDL_FillRects_f = library.LoadFunction<SDL_FillRects_d>(nameof(SDL_FillRects));
            SDL_FilterEvents_f = library.LoadFunction<SDL_FilterEvents_d>(nameof(SDL_FilterEvents));
            SDL_FlushEvent_f = library.LoadFunction<SDL_FlushEvent_d>(nameof(SDL_FlushEvent));
            SDL_FlushEvents_f = library.LoadFunction<SDL_FlushEvents_d>(nameof(SDL_FlushEvents));
            SDL_FreeCursor_f = library.LoadFunction<SDL_FreeCursor_d>(nameof(SDL_FreeCursor));
            SDL_FreeFormat_f = library.LoadFunction<SDL_FreeFormat_d>(nameof(SDL_FreeFormat));
            SDL_FreePalette_f = library.LoadFunction<SDL_FreePalette_d>(nameof(SDL_FreePalette));
            SDL_FreeSurface_f = library.LoadFunction<SDL_FreeSurface_d>(nameof(SDL_FreeSurface));
            SDL_GameControllerAddMapping_f = library.LoadFunction<SDL_GameControllerAddMapping_d>(nameof(SDL_GameControllerAddMapping));
            SDL_GameControllerClose_f = library.LoadFunction<SDL_GameControllerClose_d>(nameof(SDL_GameControllerClose));
            SDL_GameControllerFromInstanceID_f = library.LoadFunction<SDL_GameControllerFromInstanceID_d>(nameof(SDL_GameControllerFromInstanceID));
            SDL_GameControllerGetAttached_f = library.LoadFunction<SDL_GameControllerGetAttached_d>(nameof(SDL_GameControllerGetAttached));
            SDL_GameControllerGetAxis_f = library.LoadFunction<SDL_GameControllerGetAxis_d>(nameof(SDL_GameControllerGetAxis));
            SDL_GameControllerGetAxisFromString_f = library.LoadFunction<SDL_GameControllerGetAxisFromString_d>(nameof(SDL_GameControllerGetAxisFromString));
            SDL_GameControllerGetBindForAxis_f = library.LoadFunction<SDL_GameControllerGetBindForAxis_d>(nameof(SDL_GameControllerGetBindForAxis));
            SDL_GameControllerGetBindForButton_f = library.LoadFunction<SDL_GameControllerGetBindForButton_d>(nameof(SDL_GameControllerGetBindForButton));
            SDL_GameControllerGetButton_f = library.LoadFunction<SDL_GameControllerGetButton_d>(nameof(SDL_GameControllerGetButton));
            SDL_GameControllerGetButtonFromString_f = library.LoadFunction<SDL_GameControllerGetButtonFromString_d>(nameof(SDL_GameControllerGetButtonFromString));
            SDL_GameControllerGetJoystick_f = library.LoadFunction<SDL_GameControllerGetJoystick_d>(nameof(SDL_GameControllerGetJoystick));
            SDL_GameControllerGetStringForAxis_f = library.LoadFunction<SDL_GameControllerGetStringForAxis_d>(nameof(SDL_GameControllerGetStringForAxis));
            SDL_GameControllerGetStringForButton_f = library.LoadFunction<SDL_GameControllerGetStringForButton_d>(nameof(SDL_GameControllerGetStringForButton));
            SDL_GameControllerMapping_f = library.LoadFunction<SDL_GameControllerMapping_d>(nameof(SDL_GameControllerMapping));
            SDL_GameControllerMappingForGUID_f = library.LoadFunction<SDL_GameControllerMappingForGUID_d>(nameof(SDL_GameControllerMappingForGUID));
            SDL_GameControllerName_f = library.LoadFunction<SDL_GameControllerName_d>(nameof(SDL_GameControllerName));
            SDL_GameControllerNameForIndex_f = library.LoadFunction<SDL_GameControllerNameForIndex_d>(nameof(SDL_GameControllerNameForIndex));
            SDL_GameControllerOpen_f = library.LoadFunction<SDL_GameControllerOpen_d>(nameof(SDL_GameControllerOpen));
            SDL_GameControllerUpdate_f = library.LoadFunction<SDL_GameControllerUpdate_d>(nameof(SDL_GameControllerUpdate));
            SDL_GetClipboardText_f = library.LoadFunction<SDL_GetClipboardText_d>(nameof(SDL_GetClipboardText));
            SDL_GetClipRect_f = library.LoadFunction<SDL_GetClipRect_d>(nameof(SDL_GetClipRect));
            SDL_GetClosestDisplayMode_f = library.LoadFunction<SDL_GetClosestDisplayMode_d>(nameof(SDL_GetClosestDisplayMode));
            SDL_GetColorKey_f = library.LoadFunction<SDL_GetColorKey_d>(nameof(SDL_GetColorKey));
            SDL_GetCurrentDisplayMode_f = library.LoadFunction<SDL_GetCurrentDisplayMode_d>(nameof(SDL_GetCurrentDisplayMode));
            SDL_GetCurrentVideoDriver_f = library.LoadFunction<SDL_GetCurrentVideoDriver_d>(nameof(SDL_GetCurrentVideoDriver));
            SDL_GetCursor_f = library.LoadFunction<SDL_GetCursor_d>(nameof(SDL_GetCursor));
            SDL_GetDefaultCursor_f = library.LoadFunction<SDL_GetDefaultCursor_d>(nameof(SDL_GetDefaultCursor));
            SDL_GetDesktopDisplayMode_f = library.LoadFunction<SDL_GetDesktopDisplayMode_d>(nameof(SDL_GetDesktopDisplayMode));
            SDL_GetDisplayBounds_f = library.LoadFunction<SDL_GetDisplayBounds_d>(nameof(SDL_GetDisplayBounds));
            SDL_GetDisplayDPI_f = library.LoadFunction<SDL_GetDisplayDPI_d>(nameof(SDL_GetDisplayDPI));
            SDL_GetDisplayMode_f = library.LoadFunction<SDL_GetDisplayMode_d>(nameof(SDL_GetDisplayMode));
            SDL_GetDisplayName_f = library.LoadFunction<SDL_GetDisplayName_d>(nameof(SDL_GetDisplayName));
            SDL_GetDisplayUsableBounds_f = library.LoadFunction<SDL_GetDisplayUsableBounds_d>(nameof(SDL_GetDisplayUsableBounds));
            SDL_GetError_f = library.LoadFunction<SDL_GetError_d>(nameof(SDL_GetError));
            SDL_GetEventFilter_f = library.LoadFunction<SDL_GetEventFilter_d>(nameof(SDL_GetEventFilter));
            SDL_GetGlobalMouseState_f = library.LoadFunction<SDL_GetGlobalMouseState_d>(nameof(SDL_GetGlobalMouseState));
            SDL_GetGrabbedWindow_f = library.LoadFunction<SDL_GetGrabbedWindow_d>(nameof(SDL_GetGrabbedWindow));
            SDL_GetKeyboardFocus_f = library.LoadFunction<SDL_GetKeyboardFocus_d>(nameof(SDL_GetKeyboardFocus));
            SDL_GetKeyboardState_f = library.LoadFunction<SDL_GetKeyboardState_d>(nameof(SDL_GetKeyboardState));
            SDL_GetKeyFromName_f = library.LoadFunction<SDL_GetKeyFromName_d>(nameof(SDL_GetKeyFromName));
            SDL_GetKeyFromScancode_f = library.LoadFunction<SDL_GetKeyFromScancode_d>(nameof(SDL_GetKeyFromScancode));
            SDL_GetKeyName_f = library.LoadFunction<SDL_GetKeyName_d>(nameof(SDL_GetKeyName));
            SDL_GetModState_f = library.LoadFunction<SDL_GetModState_d>(nameof(SDL_GetModState));
            SDL_GetMouseFocus_f = library.LoadFunction<SDL_GetMouseFocus_d>(nameof(SDL_GetMouseFocus));
            SDL_GetMouseState_f = library.LoadFunction<SDL_GetMouseState_d>(nameof(SDL_GetMouseState));
            SDL_GetNumDisplayModes_f = library.LoadFunction<SDL_GetNumDisplayModes_d>(nameof(SDL_GetNumDisplayModes));
            SDL_GetNumRenderDrivers_f = library.LoadFunction<SDL_GetNumRenderDrivers_d>(nameof(SDL_GetNumRenderDrivers));
            SDL_GetNumTouchDevices_f = library.LoadFunction<SDL_GetNumTouchDevices_d>(nameof(SDL_GetNumTouchDevices));
            SDL_GetNumTouchFingers_f = library.LoadFunction<SDL_GetNumTouchFingers_d>(nameof(SDL_GetNumTouchFingers));
            SDL_GetNumVideoDisplays_f = library.LoadFunction<SDL_GetNumVideoDisplays_d>(nameof(SDL_GetNumVideoDisplays));
            SDL_GetNumVideoDrivers_f = library.LoadFunction<SDL_GetNumVideoDrivers_d>(nameof(SDL_GetNumVideoDrivers));
            SDL_GetPixelFormatName_f = library.LoadFunction<SDL_GetPixelFormatName_d>(nameof(SDL_GetPixelFormatName));
            SDL_GetRelativeMouseMode_f = library.LoadFunction<SDL_GetRelativeMouseMode_d>(nameof(SDL_GetRelativeMouseMode));
            SDL_GetRelativeMouseState_f = library.LoadFunction<SDL_GetRelativeMouseState_d>(nameof(SDL_GetRelativeMouseState));
            SDL_GetRenderDrawBlendMode_f = library.LoadFunction<SDL_GetRenderDrawBlendMode_d>(nameof(SDL_GetRenderDrawBlendMode));
            SDL_GetRenderDrawColor_f = library.LoadFunction<SDL_GetRenderDrawColor_d>(nameof(SDL_GetRenderDrawColor));
            SDL_GetRenderDriverInfo_f = library.LoadFunction<SDL_GetRenderDriverInfo_d>(nameof(SDL_GetRenderDriverInfo));
            SDL_GetRenderer_f = library.LoadFunction<SDL_GetRenderer_d>(nameof(SDL_GetRenderer));
            SDL_GetRendererInfo_f = library.LoadFunction<SDL_GetRendererInfo_d>(nameof(SDL_GetRendererInfo));
            SDL_GetRendererOutputSize_f = library.LoadFunction<SDL_GetRendererOutputSize_d>(nameof(SDL_GetRendererOutputSize));
            SDL_GetRenderTarget_f = library.LoadFunction<SDL_GetRenderTarget_d>(nameof(SDL_GetRenderTarget));
            SDL_GetRevision_f = library.LoadFunction<SDL_GetRevision_d>(nameof(SDL_GetRevision));
            SDL_GetRevisionNumber_f = library.LoadFunction<SDL_GetRevisionNumber_d>(nameof(SDL_GetRevisionNumber));
            SDL_GetRGB_f = library.LoadFunction<SDL_GetRGB_d>(nameof(SDL_GetRGB));
            SDL_GetRGBA_f = library.LoadFunction<SDL_GetRGBA_d>(nameof(SDL_GetRGBA));
            SDL_GetScancodeFromKey_f = library.LoadFunction<SDL_GetScancodeFromKey_d>(nameof(SDL_GetScancodeFromKey));
            SDL_GetScancodeFromName_f = library.LoadFunction<SDL_GetScancodeFromName_d>(nameof(SDL_GetScancodeFromName));
            SDL_GetScancodeName_f = library.LoadFunction<SDL_GetScancodeName_d>(nameof(SDL_GetScancodeName));
            SDL_GetSurfaceAlphaMod_f = library.LoadFunction<SDL_GetSurfaceAlphaMod_d>(nameof(SDL_GetSurfaceAlphaMod));
            SDL_GetSurfaceBlendMode_f = library.LoadFunction<SDL_GetSurfaceBlendMode_d>(nameof(SDL_GetSurfaceBlendMode));
            SDL_GetSurfaceColorMod_f = library.LoadFunction<SDL_GetSurfaceColorMod_d>(nameof(SDL_GetSurfaceColorMod));
            SDL_GetTextureAlphaMod_f = library.LoadFunction<SDL_GetTextureAlphaMod_d>(nameof(SDL_GetTextureAlphaMod));
            SDL_GetTextureBlendMode_f = library.LoadFunction<SDL_GetTextureBlendMode_d>(nameof(SDL_GetTextureBlendMode));
            SDL_GetTextureColorMod_f = library.LoadFunction<SDL_GetTextureColorMod_d>(nameof(SDL_GetTextureColorMod));
            SDL_GetTouchDevice_f = library.LoadFunction<SDL_GetTouchDevice_d>(nameof(SDL_GetTouchDevice));
            SDL_GetTouchFinger_f = library.LoadFunction<SDL_GetTouchFinger_d>(nameof(SDL_GetTouchFinger));
            SDL_GetVersion_f = library.LoadFunction<SDL_GetVersion_d>(nameof(SDL_GetVersion));
            SDL_GetVideoDriver_f = library.LoadFunction<SDL_GetVideoDriver_d>(nameof(SDL_GetVideoDriver));
            SDL_GetWindowBordersSize_f = library.LoadFunction<SDL_GetWindowBordersSize_d>(nameof(SDL_GetWindowBordersSize));
            SDL_GetWindowBrightness_f = library.LoadFunction<SDL_GetWindowBrightness_d>(nameof(SDL_GetWindowBrightness));
            SDL_GetWindowData_f = library.LoadFunction<SDL_GetWindowData_d>(nameof(SDL_GetWindowData));
            SDL_GetWindowDisplayIndex_f = library.LoadFunction<SDL_GetWindowDisplayIndex_d>(nameof(SDL_GetWindowDisplayIndex));
            SDL_GetWindowDisplayMode_f = library.LoadFunction<SDL_GetWindowDisplayMode_d>(nameof(SDL_GetWindowDisplayMode));
            SDL_GetWindowFlags_f = library.LoadFunction<SDL_GetWindowFlags_d>(nameof(SDL_GetWindowFlags));
            SDL_GetWindowFromID_f = library.LoadFunction<SDL_GetWindowFromID_d>(nameof(SDL_GetWindowFromID));
            SDL_GetWindowMaximumSize_f = library.LoadFunction<SDL_GetWindowMaximumSize_d>(nameof(SDL_GetWindowMaximumSize));
            SDL_GetWindowMinimumSize_f = library.LoadFunction<SDL_GetWindowMinimumSize_d>(nameof(SDL_GetWindowMinimumSize));
            SDL_GetWindowOpacity_f = library.LoadFunction<SDL_GetWindowOpacity_d>(nameof(SDL_GetWindowOpacity));
            SDL_GetWindowPixelFormat_f = library.LoadFunction<SDL_GetWindowPixelFormat_d>(nameof(SDL_GetWindowPixelFormat));
            SDL_GetWindowPosition_f = library.LoadFunction<SDL_GetWindowPosition_d>(nameof(SDL_GetWindowPosition));
            SDL_GetWindowSize_f = library.LoadFunction<SDL_GetWindowSize_d>(nameof(SDL_GetWindowSize));
            SDL_GetWindowTitle_f = library.LoadFunction<SDL_GetWindowTitle_d>(nameof(SDL_GetWindowTitle));
            SDL_GetWindowWMInfo_f = library.LoadFunction<SDL_GetWindowWMInfo_d>(nameof(SDL_GetWindowWMInfo));
            SDL_GL_BindTexture_f = library.LoadFunction<SDL_GL_BindTexture_d>(nameof(SDL_GL_BindTexture));
            SDL_GL_CreateContext_f = library.LoadFunction<SDL_GL_CreateContext_d>(nameof(SDL_GL_CreateContext));
            SDL_GL_DeleteContext_f = library.LoadFunction<SDL_GL_DeleteContext_d>(nameof(SDL_GL_DeleteContext));
            SDL_GL_ExtensionSupported_f = library.LoadFunction<SDL_GL_ExtensionSupported_d>(nameof(SDL_GL_ExtensionSupported));
            SDL_GL_GetAttribute_f = library.LoadFunction<SDL_GL_GetAttribute_d>(nameof(SDL_GL_GetAttribute));
            SDL_GL_GetCurrentContext_f = library.LoadFunction<SDL_GL_GetCurrentContext_d>(nameof(SDL_GL_GetCurrentContext));
            SDL_GL_GetCurrentWindow_f = library.LoadFunction<SDL_GL_GetCurrentWindow_d>(nameof(SDL_GL_GetCurrentWindow));
            SDL_GL_GetDrawableSize_f = library.LoadFunction<SDL_GL_GetDrawableSize_d>(nameof(SDL_GL_GetDrawableSize));
            SDL_GL_GetProcAddress_f = library.LoadFunction<SDL_GL_GetProcAddress_d>(nameof(SDL_GL_GetProcAddress));
            SDL_GL_GetSwapInterval_f = library.LoadFunction<SDL_GL_GetSwapInterval_d>(nameof(SDL_GL_GetSwapInterval));
            SDL_GL_LoadLibrary_f = library.LoadFunction<SDL_GL_LoadLibrary_d>(nameof(SDL_GL_LoadLibrary));
            SDL_GL_MakeCurrent_f = library.LoadFunction<SDL_GL_MakeCurrent_d>(nameof(SDL_GL_MakeCurrent));
            SDL_GL_ResetAttributes_f = library.LoadFunction<SDL_GL_ResetAttributes_d>(nameof(SDL_GL_ResetAttributes));
            SDL_GL_SetAttribute_f = library.LoadFunction<SDL_GL_SetAttribute_d>(nameof(SDL_GL_SetAttribute));
            SDL_GL_SetSwapInterval_f = library.LoadFunction<SDL_GL_SetSwapInterval_d>(nameof(SDL_GL_SetSwapInterval));
            SDL_GL_SwapWindow_f = library.LoadFunction<SDL_GL_SwapWindow_d>(nameof(SDL_GL_SwapWindow));
            SDL_GL_UnbindTexture_f = library.LoadFunction<SDL_GL_UnbindTexture_d>(nameof(SDL_GL_UnbindTexture));
            SDL_GL_UnloadLibrary_f = library.LoadFunction<SDL_GL_UnloadLibrary_d>(nameof(SDL_GL_UnloadLibrary));
            SDL_HasClipboardText_f = library.LoadFunction<SDL_HasClipboardText_d>(nameof(SDL_HasClipboardText));
            SDL_HasEvent_f = library.LoadFunction<SDL_HasEvent_d>(nameof(SDL_HasEvent));
            SDL_HasEvents_f = library.LoadFunction<SDL_HasEvents_d>(nameof(SDL_HasEvents));
            SDL_HasScreenKeyboardSupport_f = library.LoadFunction<SDL_HasScreenKeyboardSupport_d>(nameof(SDL_HasScreenKeyboardSupport));
            SDL_HideWindow_f = library.LoadFunction<SDL_HideWindow_d>(nameof(SDL_HideWindow));
            SDL_Init_f = library.LoadFunction<SDL_Init_d>(nameof(SDL_Init));
            SDL_InitSubSystem_f = library.LoadFunction<SDL_InitSubSystem_d>(nameof(SDL_InitSubSystem));
            SDL_IsGameController_f = library.LoadFunction<SDL_IsGameController_d>(nameof(SDL_IsGameController));
            SDL_IsScreenKeyboardShown_f = library.LoadFunction<SDL_IsScreenKeyboardShown_d>(nameof(SDL_IsScreenKeyboardShown));
            SDL_IsScreenSaverEnabled_f = library.LoadFunction<SDL_IsScreenSaverEnabled_d>(nameof(SDL_IsScreenSaverEnabled));
            SDL_IsTextInputActive_f = library.LoadFunction<SDL_IsTextInputActive_d>(nameof(SDL_IsTextInputActive));
            SDL_JoystickClose_f = library.LoadFunction<SDL_JoystickClose_d>(nameof(SDL_JoystickClose));
            SDL_JoystickCurrentPowerLevel_f = library.LoadFunction<SDL_JoystickCurrentPowerLevel_d>(nameof(SDL_JoystickCurrentPowerLevel));
            SDL_JoystickFromInstanceID_f = library.LoadFunction<SDL_JoystickFromInstanceID_d>(nameof(SDL_JoystickFromInstanceID));
            SDL_JoystickGetAttached_f = library.LoadFunction<SDL_JoystickGetAttached_d>(nameof(SDL_JoystickGetAttached));
            SDL_JoystickGetAxis_f = library.LoadFunction<SDL_JoystickGetAxis_d>(nameof(SDL_JoystickGetAxis));
            SDL_JoystickGetBall_f = library.LoadFunction<SDL_JoystickGetBall_d>(nameof(SDL_JoystickGetBall));
            SDL_JoystickGetButton_f = library.LoadFunction<SDL_JoystickGetButton_d>(nameof(SDL_JoystickGetButton));
            SDL_JoystickGetDeviceGUID_f = library.LoadFunction<SDL_JoystickGetDeviceGUID_d>(nameof(SDL_JoystickGetDeviceGUID));
            SDL_JoystickGetGUID_f = library.LoadFunction<SDL_JoystickGetGUID_d>(nameof(SDL_JoystickGetGUID));
            SDL_JoystickGetGUIDFromString_f = library.LoadFunction<SDL_JoystickGetGUIDFromString_d>(nameof(SDL_JoystickGetGUIDFromString));
            SDL_JoystickGetGUIDString_f = library.LoadFunction<SDL_JoystickGetGUIDString_d>(nameof(SDL_JoystickGetGUIDString));
            SDL_JoystickGetHat_f = library.LoadFunction<SDL_JoystickGetHat_d>(nameof(SDL_JoystickGetHat));
            SDL_JoystickInstanceID_f = library.LoadFunction<SDL_JoystickInstanceID_d>(nameof(SDL_JoystickInstanceID));
            SDL_JoystickName_f = library.LoadFunction<SDL_JoystickName_d>(nameof(SDL_JoystickName));
            SDL_JoystickNameForIndex_f = library.LoadFunction<SDL_JoystickNameForIndex_d>(nameof(SDL_JoystickNameForIndex));
            SDL_JoystickNumAxes_f = library.LoadFunction<SDL_JoystickNumAxes_d>(nameof(SDL_JoystickNumAxes));
            SDL_JoystickNumBalls_f = library.LoadFunction<SDL_JoystickNumBalls_d>(nameof(SDL_JoystickNumBalls));
            SDL_JoystickNumButtons_f = library.LoadFunction<SDL_JoystickNumButtons_d>(nameof(SDL_JoystickNumButtons));
            SDL_JoystickNumHats_f = library.LoadFunction<SDL_JoystickNumHats_d>(nameof(SDL_JoystickNumHats));
            SDL_JoystickOpen_f = library.LoadFunction<SDL_JoystickOpen_d>(nameof(SDL_JoystickOpen));
            SDL_JoystickUpdate_f = library.LoadFunction<SDL_JoystickUpdate_d>(nameof(SDL_JoystickUpdate));
            SDL_LockSurface_f = library.LoadFunction<SDL_LockSurface_d>(nameof(SDL_LockSurface));
            SDL_LockTexture_f = library.LoadFunction<SDL_LockTexture_d>(nameof(SDL_LockTexture));
            SDL_LowerBlit_f = library.LoadFunction<SDL_LowerBlit_d>(nameof(SDL_LowerBlit));
            SDL_LowerBlitScaled_f = library.LoadFunction<SDL_LowerBlitScaled_d>(nameof(SDL_LowerBlitScaled));
            SDL_MapRGB_f = library.LoadFunction<SDL_MapRGB_d>(nameof(SDL_MapRGB));
            SDL_MapRGBA_f = library.LoadFunction<SDL_MapRGBA_d>(nameof(SDL_MapRGBA));
            SDL_MasksToPixelFormatEnum_f = library.LoadFunction<SDL_MasksToPixelFormatEnum_d>(nameof(SDL_MasksToPixelFormatEnum));
            SDL_MaximizeWindow_f = library.LoadFunction<SDL_MaximizeWindow_d>(nameof(SDL_MaximizeWindow));
            SDL_MinimizeWindow_f = library.LoadFunction<SDL_MinimizeWindow_d>(nameof(SDL_MinimizeWindow));
            SDL_NumJoysticks_f = library.LoadFunction<SDL_NumJoysticks_d>(nameof(SDL_NumJoysticks));
            SDL_PeepEvents_f = library.LoadFunction<SDL_PeepEvents_d>(nameof(SDL_PeepEvents));
            SDL_PixelFormatEnumToMasks_f = library.LoadFunction<SDL_PixelFormatEnumToMasks_d>(nameof(SDL_PixelFormatEnumToMasks));
            SDL_PollEvent_f = library.LoadFunction<SDL_PollEvent_d>(nameof(SDL_PollEvent));
            SDL_PumpEvents_f = library.LoadFunction<SDL_PumpEvents_d>(nameof(SDL_PumpEvents));
            SDL_PushEvent_f = library.LoadFunction<SDL_PushEvent_d>(nameof(SDL_PushEvent));
            SDL_QueryTexture_f = library.LoadFunction<SDL_QueryTexture_d>(nameof(SDL_QueryTexture));
            SDL_Quit_f = library.LoadFunction<SDL_Quit_d>(nameof(SDL_Quit));
            SDL_QuitSubSystem_f = library.LoadFunction<SDL_QuitSubSystem_d>(nameof(SDL_QuitSubSystem));
            SDL_RaiseWindow_f = library.LoadFunction<SDL_RaiseWindow_d>(nameof(SDL_RaiseWindow));
            SDL_RegisterEvents_f = library.LoadFunction<SDL_RegisterEvents_d>(nameof(SDL_RegisterEvents));
            SDL_RenderClear_f = library.LoadFunction<SDL_RenderClear_d>(nameof(SDL_RenderClear));
            SDL_RenderCopy_f = library.LoadFunction<SDL_RenderCopy_d>(nameof(SDL_RenderCopy));
            SDL_RenderCopyEx_f = library.LoadFunction<SDL_RenderCopyEx_d>(nameof(SDL_RenderCopyEx));
            SDL_RenderDrawLine_f = library.LoadFunction<SDL_RenderDrawLine_d>(nameof(SDL_RenderDrawLine));
            SDL_RenderDrawLines_f = library.LoadFunction<SDL_RenderDrawLines_d>(nameof(SDL_RenderDrawLines));
            SDL_RenderDrawPoint_f = library.LoadFunction<SDL_RenderDrawPoint_d>(nameof(SDL_RenderDrawPoint));
            SDL_RenderDrawPoints_f = library.LoadFunction<SDL_RenderDrawPoints_d>(nameof(SDL_RenderDrawPoints));
            SDL_RenderDrawRect_f = library.LoadFunction<SDL_RenderDrawRect_d>(nameof(SDL_RenderDrawRect));
            SDL_RenderDrawRects_f = library.LoadFunction<SDL_RenderDrawRects_d>(nameof(SDL_RenderDrawRects));
            SDL_RenderFillRect_f = library.LoadFunction<SDL_RenderFillRect_d>(nameof(SDL_RenderFillRect));
            SDL_RenderFillRects_f = library.LoadFunction<SDL_RenderFillRects_d>(nameof(SDL_RenderFillRects));
            SDL_RenderGetClipRect_f = library.LoadFunction<SDL_RenderGetClipRect_d>(nameof(SDL_RenderGetClipRect));
            SDL_RenderGetIntegerScale_f = library.LoadFunction<SDL_RenderGetIntegerScale_d>(nameof(SDL_RenderGetIntegerScale));
            SDL_RenderGetLogicalSize_f = library.LoadFunction<SDL_RenderGetLogicalSize_d>(nameof(SDL_RenderGetLogicalSize));
            SDL_RenderGetScale_f = library.LoadFunction<SDL_RenderGetScale_d>(nameof(SDL_RenderGetScale));
            SDL_RenderGetViewport_f = library.LoadFunction<SDL_RenderGetViewport_d>(nameof(SDL_RenderGetViewport));
            SDL_RenderIsClipEnabled_f = library.LoadFunction<SDL_RenderIsClipEnabled_d>(nameof(SDL_RenderIsClipEnabled));
            SDL_RenderPresent_f = library.LoadFunction<SDL_RenderPresent_d>(nameof(SDL_RenderPresent));
            SDL_RenderReadPixels_f = library.LoadFunction<SDL_RenderReadPixels_d>(nameof(SDL_RenderReadPixels));
            SDL_RenderSetClipRect_f = library.LoadFunction<SDL_RenderSetClipRect_d>(nameof(SDL_RenderSetClipRect));
            SDL_RenderSetIntegerScale_f = library.LoadFunction<SDL_RenderSetIntegerScale_d>(nameof(SDL_RenderSetIntegerScale));
            SDL_RenderSetLogicalSize_f = library.LoadFunction<SDL_RenderSetLogicalSize_d>(nameof(SDL_RenderSetLogicalSize));
            SDL_RenderSetScale_f = library.LoadFunction<SDL_RenderSetScale_d>(nameof(SDL_RenderSetScale));
            SDL_RenderSetViewport_f = library.LoadFunction<SDL_RenderSetViewport_d>(nameof(SDL_RenderSetViewport));
            SDL_RenderTargetSupported_f = library.LoadFunction<SDL_RenderTargetSupported_d>(nameof(SDL_RenderTargetSupported));
            SDL_RestoreWindow_f = library.LoadFunction<SDL_RestoreWindow_d>(nameof(SDL_RestoreWindow));
            SDL_SetClipboardText_f = library.LoadFunction<SDL_SetClipboardText_d>(nameof(SDL_SetClipboardText));
            SDL_SetClipRect_f = library.LoadFunction<SDL_SetClipRect_d>(nameof(SDL_SetClipRect));
            SDL_SetColorKey_f = library.LoadFunction<SDL_SetColorKey_d>(nameof(SDL_SetColorKey));
            SDL_SetCursor_f = library.LoadFunction<SDL_SetCursor_d>(nameof(SDL_SetCursor));
            SDL_SetEventFilter_f = library.LoadFunction<SDL_SetEventFilter_d>(nameof(SDL_SetEventFilter));
            SDL_SetModState_f = library.LoadFunction<SDL_SetModState_d>(nameof(SDL_SetModState));
            SDL_SetPaletteColors_f = library.LoadFunction<SDL_SetPaletteColors_d>(nameof(SDL_SetPaletteColors));
            SDL_SetPixelFormatPalette_f = library.LoadFunction<SDL_SetPixelFormatPalette_d>(nameof(SDL_SetPixelFormatPalette));
            SDL_SetRelativeMouseMode_f = library.LoadFunction<SDL_SetRelativeMouseMode_d>(nameof(SDL_SetRelativeMouseMode));
            SDL_SetRenderDrawBlendMode_f = library.LoadFunction<SDL_SetRenderDrawBlendMode_d>(nameof(SDL_SetRenderDrawBlendMode));
            SDL_SetRenderDrawColor_f = library.LoadFunction<SDL_SetRenderDrawColor_d>(nameof(SDL_SetRenderDrawColor));
            SDL_SetRenderTarget_f = library.LoadFunction<SDL_SetRenderTarget_d>(nameof(SDL_SetRenderTarget));
            SDL_SetSurfaceAlphaMod_f = library.LoadFunction<SDL_SetSurfaceAlphaMod_d>(nameof(SDL_SetSurfaceAlphaMod));
            SDL_SetSurfaceBlendMode_f = library.LoadFunction<SDL_SetSurfaceBlendMode_d>(nameof(SDL_SetSurfaceBlendMode));
            SDL_SetSurfaceColorMod_f = library.LoadFunction<SDL_SetSurfaceColorMod_d>(nameof(SDL_SetSurfaceColorMod));
            SDL_SetSurfacePalette_f = library.LoadFunction<SDL_SetSurfacePalette_d>(nameof(SDL_SetSurfacePalette));
            SDL_SetSurfaceRLE_f = library.LoadFunction<SDL_SetSurfaceRLE_d>(nameof(SDL_SetSurfaceRLE));
            SDL_SetTextInputRect_f = library.LoadFunction<SDL_SetTextInputRect_d>(nameof(SDL_SetTextInputRect));
            SDL_SetTextureAlphaMod_f = library.LoadFunction<SDL_SetTextureAlphaMod_d>(nameof(SDL_SetTextureAlphaMod));
            SDL_SetTextureBlendMode_f = library.LoadFunction<SDL_SetTextureBlendMode_d>(nameof(SDL_SetTextureBlendMode));
            SDL_SetTextureColorMod_f = library.LoadFunction<SDL_SetTextureColorMod_d>(nameof(SDL_SetTextureColorMod));
            SDL_SetWindowBordered_f = library.LoadFunction<SDL_SetWindowBordered_d>(nameof(SDL_SetWindowBordered));
            SDL_SetWindowBrightness_f = library.LoadFunction<SDL_SetWindowBrightness_d>(nameof(SDL_SetWindowBrightness));
            SDL_SetWindowData_f = library.LoadFunction<SDL_SetWindowData_d>(nameof(SDL_SetWindowData));
            SDL_SetWindowDisplayMode_f = library.LoadFunction<SDL_SetWindowDisplayMode_d>(nameof(SDL_SetWindowDisplayMode));
            SDL_SetWindowFullscreen_f = library.LoadFunction<SDL_SetWindowFullscreen_d>(nameof(SDL_SetWindowFullscreen));
            SDL_SetWindowGammaRamp_f = library.LoadFunction<SDL_SetWindowGammaRamp_d>(nameof(SDL_SetWindowGammaRamp));
            SDL_SetWindowGrab_f = library.LoadFunction<SDL_SetWindowGrab_d>(nameof(SDL_SetWindowGrab));
            SDL_SetWindowHitTest_f = library.LoadFunction<SDL_SetWindowHitTest_d>(nameof(SDL_SetWindowHitTest));
            SDL_SetWindowInputFocus_f = library.LoadFunction<SDL_SetWindowInputFocus_d>(nameof(SDL_SetWindowInputFocus));
            SDL_SetWindowMaximumSize_f = library.LoadFunction<SDL_SetWindowMaximumSize_d>(nameof(SDL_SetWindowMaximumSize));
            SDL_SetWindowMinimumSize_f = library.LoadFunction<SDL_SetWindowMinimumSize_d>(nameof(SDL_SetWindowMinimumSize));
            SDL_SetWindowModalFor_f = library.LoadFunction<SDL_SetWindowModalFor_d>(nameof(SDL_SetWindowModalFor));
            SDL_SetWindowOpacity_f = library.LoadFunction<SDL_SetWindowOpacity_d>(nameof(SDL_SetWindowOpacity));
            SDL_SetWindowPosition_f = library.LoadFunction<SDL_SetWindowPosition_d>(nameof(SDL_SetWindowPosition));
            SDL_SetWindowResizable_f = library.LoadFunction<SDL_SetWindowResizable_d>(nameof(SDL_SetWindowResizable));
            SDL_SetWindowSize_f = library.LoadFunction<SDL_SetWindowSize_d>(nameof(SDL_SetWindowSize));
            SDL_SetWindowTitle_f = library.LoadFunction<SDL_SetWindowTitle_d>(nameof(SDL_SetWindowTitle));
            SDL_ShowCursor_f = library.LoadFunction<SDL_ShowCursor_d>(nameof(SDL_ShowCursor));
            SDL_ShowWindow_f = library.LoadFunction<SDL_ShowWindow_d>(nameof(SDL_ShowWindow));
            SDL_StartTextInput_f = library.LoadFunction<SDL_StartTextInput_d>(nameof(SDL_StartTextInput));
            SDL_StopTextInput_f = library.LoadFunction<SDL_StopTextInput_d>(nameof(SDL_StopTextInput));
            SDL_UnlockSurface_f = library.LoadFunction<SDL_UnlockSurface_d>(nameof(SDL_UnlockSurface));
            SDL_UnlockTexture_f = library.LoadFunction<SDL_UnlockTexture_d>(nameof(SDL_UnlockTexture));
            SDL_UpdateTexture_f = library.LoadFunction<SDL_UpdateTexture_d>(nameof(SDL_UpdateTexture));
            SDL_UpdateYUVTexture_f = library.LoadFunction<SDL_UpdateYUVTexture_d>(nameof(SDL_UpdateYUVTexture));
            SDL_UpperBlit_f = library.LoadFunction<SDL_UpperBlit_d>(nameof(SDL_UpperBlit));
            SDL_UpperBlitScaled_f = library.LoadFunction<SDL_UpperBlitScaled_d>(nameof(SDL_UpperBlitScaled));
            SDL_VideoInit_f = library.LoadFunction<SDL_VideoInit_d>(nameof(SDL_VideoInit));
            SDL_VideoQuit_f = library.LoadFunction<SDL_VideoQuit_d>(nameof(SDL_VideoQuit));
            SDL_WaitEvent_f = library.LoadFunction<SDL_WaitEvent_d>(nameof(SDL_WaitEvent));
            SDL_WaitEventTimeout_f = library.LoadFunction<SDL_WaitEventTimeout_d>(nameof(SDL_WaitEventTimeout));
            SDL_WarpMouseGlobal_f = library.LoadFunction<SDL_WarpMouseGlobal_d>(nameof(SDL_WarpMouseGlobal));
            SDL_WarpMouseInWindow_f = library.LoadFunction<SDL_WarpMouseInWindow_d>(nameof(SDL_WarpMouseInWindow));
            SDL_WasInit_f = library.LoadFunction<SDL_WasInit_d>(nameof(SDL_WasInit));
        }
    }
}
