// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE"]/*' />
public enum D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_DISABLED"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_DISABLED = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SWITCHABLE"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SWITCHABLE = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_WIENER"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_WIENER = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SGRPROJ"]/*' />
    D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SGRPROJ = 3,
}
