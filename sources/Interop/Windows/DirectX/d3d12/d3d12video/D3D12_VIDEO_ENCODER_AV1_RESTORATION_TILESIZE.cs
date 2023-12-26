// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE"]/*' />
public enum D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128 = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256 = 4,
}