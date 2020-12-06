// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DVERTEXBLENDFLAGS
    {
        D3DVBF_DISABLE = 0,
        D3DVBF_1WEIGHTS = 1,
        D3DVBF_2WEIGHTS = 2,
        D3DVBF_3WEIGHTS = 3,
        D3DVBF_TWEENING = 255,
        D3DVBF_0WEIGHTS = 256,
        D3DVBF_FORCE_DWORD = 0x7fffffff,
    }
}
