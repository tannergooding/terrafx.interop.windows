// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D2D1_WINDOW_STATE : uint
    {
        D2D1_WINDOW_STATE_NONE = 0x0000000,
        D2D1_WINDOW_STATE_OCCLUDED = 0x0000001,
        D2D1_WINDOW_STATE_FORCE_DWORD = 0xffffffff,
    }
}
