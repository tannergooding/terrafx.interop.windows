// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DBACKBUFFER_TYPE : uint
    {
        D3DBACKBUFFER_TYPE_MONO = 0,
        D3DBACKBUFFER_TYPE_LEFT = 1,
        D3DBACKBUFFER_TYPE_RIGHT = 2,
        D3DBACKBUFFER_TYPE_FORCE_DWORD = 0x7fffffff,
    }
}
