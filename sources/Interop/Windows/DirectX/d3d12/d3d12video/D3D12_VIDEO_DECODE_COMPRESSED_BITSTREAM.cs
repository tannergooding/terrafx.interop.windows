// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM
{
    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.pBuffer"]/*' />
    public ID3D12Resource* pBuffer;

    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM.Size"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Size;
}
