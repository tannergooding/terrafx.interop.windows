// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DCOMPOSERECTSOP
    {
        D3DCOMPOSERECTS_COPY = 1,
        D3DCOMPOSERECTS_OR = 2,
        D3DCOMPOSERECTS_AND = 3,
        D3DCOMPOSERECTS_NEG = 4,
        D3DCOMPOSERECTS_FORCE_DWORD = 0x7fffffff,
    }
}
