// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DSTENCILOP : uint
    {
        D3DSTENCILOP_KEEP = 1,
        D3DSTENCILOP_ZERO = 2,
        D3DSTENCILOP_REPLACE = 3,
        D3DSTENCILOP_INCRSAT = 4,
        D3DSTENCILOP_DECRSAT = 5,
        D3DSTENCILOP_INVERT = 6,
        D3DSTENCILOP_INCR = 7,
        D3DSTENCILOP_DECR = 8,
        D3DSTENCILOP_FORCE_DWORD = 0x7fffffff,
    }
}
