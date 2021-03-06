// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DVD_TIMECODE_FLAGS
    {
        DVD_TC_FLAG_25fps = 0x1,
        DVD_TC_FLAG_30fps = 0x2,
        DVD_TC_FLAG_DropFrame = 0x4,
        DVD_TC_FLAG_Interpolated = 0x8,
    }
}
