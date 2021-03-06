// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_SHADER_CACHE_CONTROL_FLAGS
    {
        D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE = 0x1,
        D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE = 0x2,
        D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR = 0x4,
    }
}
