// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DTEXTUREOP
    {
        D3DTOP_DISABLE = 1,
        D3DTOP_SELECTARG1 = 2,
        D3DTOP_SELECTARG2 = 3,
        D3DTOP_MODULATE = 4,
        D3DTOP_MODULATE2X = 5,
        D3DTOP_MODULATE4X = 6,
        D3DTOP_ADD = 7,
        D3DTOP_ADDSIGNED = 8,
        D3DTOP_ADDSIGNED2X = 9,
        D3DTOP_SUBTRACT = 10,
        D3DTOP_ADDSMOOTH = 11,
        D3DTOP_BLENDDIFFUSEALPHA = 12,
        D3DTOP_BLENDTEXTUREALPHA = 13,
        D3DTOP_BLENDFACTORALPHA = 14,
        D3DTOP_BLENDTEXTUREALPHAPM = 15,
        D3DTOP_BLENDCURRENTALPHA = 16,
        D3DTOP_PREMODULATE = 17,
        D3DTOP_MODULATEALPHA_ADDCOLOR = 18,
        D3DTOP_MODULATECOLOR_ADDALPHA = 19,
        D3DTOP_MODULATEINVALPHA_ADDCOLOR = 20,
        D3DTOP_MODULATEINVCOLOR_ADDALPHA = 21,
        D3DTOP_BUMPENVMAP = 22,
        D3DTOP_BUMPENVMAPLUMINANCE = 23,
        D3DTOP_DOTPRODUCT3 = 24,
        D3DTOP_MULTIPLYADD = 25,
        D3DTOP_LERP = 26,
        D3DTOP_FORCE_DWORD = 0x7fffffff,
    }
}
