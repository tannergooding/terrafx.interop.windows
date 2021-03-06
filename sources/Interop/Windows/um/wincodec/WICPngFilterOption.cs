// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICPngFilterOption
    {
        WICPngFilterUnspecified = 0,
        WICPngFilterNone = 0x1,
        WICPngFilterSub = 0x2,
        WICPngFilterUp = 0x3,
        WICPngFilterAverage = 0x4,
        WICPngFilterPaeth = 0x5,
        WICPngFilterAdaptive = 0x6,
        WICPNGFILTEROPTION_FORCE_DWORD = 0x7fffffff,
    }
}
