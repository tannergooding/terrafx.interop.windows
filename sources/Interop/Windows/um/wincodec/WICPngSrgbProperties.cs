// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICPngSrgbProperties : uint
    {
        WICPngSrgbRenderingIntent = 0x1,
        WICPngSrgbProperties_FORCE_DWORD = 0x7fffffff,
    }
}
