// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DSWAPEFFECT : uint
    {
        D3DSWAPEFFECT_DISCARD = 1,
        D3DSWAPEFFECT_FLIP = 2,
        D3DSWAPEFFECT_COPY = 3,
        D3DSWAPEFFECT_OVERLAY = 4,
        D3DSWAPEFFECT_FLIPEX = 5,
        D3DSWAPEFFECT_FORCE_DWORD = 0x7fffffff,
    }
}
