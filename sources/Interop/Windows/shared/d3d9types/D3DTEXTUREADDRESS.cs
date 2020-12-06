// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DTEXTUREADDRESS
    {
        D3DTADDRESS_WRAP = 1,
        D3DTADDRESS_MIRROR = 2,
        D3DTADDRESS_CLAMP = 3,
        D3DTADDRESS_BORDER = 4,
        D3DTADDRESS_MIRRORONCE = 5,
        D3DTADDRESS_FORCE_DWORD = 0x7fffffff,
    }
}
