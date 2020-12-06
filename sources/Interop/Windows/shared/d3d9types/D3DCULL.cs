// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DCULL : uint
    {
        D3DCULL_NONE = 1,
        D3DCULL_CW = 2,
        D3DCULL_CCW = 3,
        D3DCULL_FORCE_DWORD = 0x7fffffff,
    }
}
