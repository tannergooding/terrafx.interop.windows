// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DLIGHTTYPE
    {
        D3DLIGHT_POINT = 1,
        D3DLIGHT_SPOT = 2,
        D3DLIGHT_DIRECTIONAL = 3,
        D3DLIGHT_FORCE_DWORD = 0x7fffffff,
    }
}
