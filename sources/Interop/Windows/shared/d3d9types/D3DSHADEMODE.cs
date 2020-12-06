// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DSHADEMODE
    {
        D3DSHADE_FLAT = 1,
        D3DSHADE_GOURAUD = 2,
        D3DSHADE_PHONG = 3,
        D3DSHADE_FORCE_DWORD = 0x7fffffff,
    }
}
