// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DZBUFFERTYPE
    {
        D3DZB_FALSE = 0,
        D3DZB_TRUE = 1,
        D3DZB_USEW = 2,
        D3DZB_FORCE_DWORD = 0x7fffffff,
    }
}
