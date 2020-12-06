// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DBLENDOP : uint
    {
        D3DBLENDOP_ADD = 1,
        D3DBLENDOP_SUBTRACT = 2,
        D3DBLENDOP_REVSUBTRACT = 3,
        D3DBLENDOP_MIN = 4,
        D3DBLENDOP_MAX = 5,
        D3DBLENDOP_FORCE_DWORD = 0x7fffffff,
    }
}
