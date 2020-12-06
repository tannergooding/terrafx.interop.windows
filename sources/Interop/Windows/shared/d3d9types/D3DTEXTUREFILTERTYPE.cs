// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DTEXTUREFILTERTYPE
    {
        D3DTEXF_NONE = 0,
        D3DTEXF_POINT = 1,
        D3DTEXF_LINEAR = 2,
        D3DTEXF_ANISOTROPIC = 3,
        D3DTEXF_PYRAMIDALQUAD = 6,
        D3DTEXF_GAUSSIANQUAD = 7,
        D3DTEXF_CONVOLUTIONMONO = 8,
        D3DTEXF_FORCE_DWORD = 0x7fffffff,
    }
}
