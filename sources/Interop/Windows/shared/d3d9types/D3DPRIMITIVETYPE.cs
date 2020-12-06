// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DPRIMITIVETYPE
    {
        D3DPT_POINTLIST = 1,
        D3DPT_LINELIST = 2,
        D3DPT_LINESTRIP = 3,
        D3DPT_TRIANGLELIST = 4,
        D3DPT_TRIANGLESTRIP = 5,
        D3DPT_TRIANGLEFAN = 6,
        D3DPT_FORCE_DWORD = 0x7fffffff,
    }
}
