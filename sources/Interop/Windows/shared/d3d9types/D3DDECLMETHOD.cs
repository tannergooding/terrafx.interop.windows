// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DDECLMETHOD
    {
        D3DDECLMETHOD_DEFAULT = 0,
        D3DDECLMETHOD_PARTIALU,
        D3DDECLMETHOD_PARTIALV,
        D3DDECLMETHOD_CROSSUV,
        D3DDECLMETHOD_UV,
        D3DDECLMETHOD_LOOKUP,
        D3DDECLMETHOD_LOOKUPPRESAMPLED,
    }
}
