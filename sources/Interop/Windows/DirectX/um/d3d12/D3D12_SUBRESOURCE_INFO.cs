// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SUBRESOURCE_INFO.xml' path='doc/member[@name="D3D12_SUBRESOURCE_INFO"]/*' />
public partial struct D3D12_SUBRESOURCE_INFO
{
    /// <include file='D3D12_SUBRESOURCE_INFO.xml' path='doc/member[@name="D3D12_SUBRESOURCE_INFO.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_SUBRESOURCE_INFO.xml' path='doc/member[@name="D3D12_SUBRESOURCE_INFO.RowPitch"]/*' />
    public uint RowPitch;

    /// <include file='D3D12_SUBRESOURCE_INFO.xml' path='doc/member[@name="D3D12_SUBRESOURCE_INFO.DepthPitch"]/*' />
    public uint DepthPitch;
}
