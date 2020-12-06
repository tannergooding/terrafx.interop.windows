// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DFOGMODE
    {
        D3DFOG_NONE = 0,
        D3DFOG_EXP = 1,
        D3DFOG_EXP2 = 2,
        D3DFOG_LINEAR = 3,
        D3DFOG_FORCE_DWORD = 0x7fffffff,
    }
}
