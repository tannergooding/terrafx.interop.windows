// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DDEGREETYPE
    {
        D3DDEGREE_LINEAR = 1,
        D3DDEGREE_QUADRATIC = 2,
        D3DDEGREE_CUBIC = 3,
        D3DDEGREE_QUINTIC = 5,
        D3DDEGREE_FORCE_DWORD = 0x7fffffff,
    }
}
