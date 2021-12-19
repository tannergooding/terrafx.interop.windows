// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXCUBE_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_SRV"]/*' />
public partial struct D3D12_TEXCUBE_SRV
{
    /// <include file='D3D12_TEXCUBE_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_SRV.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D12_TEXCUBE_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_SRV.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D12_TEXCUBE_SRV.xml' path='doc/member[@name="D3D12_TEXCUBE_SRV.ResourceMinLODClamp"]/*' />
    public float ResourceMinLODClamp;
}
