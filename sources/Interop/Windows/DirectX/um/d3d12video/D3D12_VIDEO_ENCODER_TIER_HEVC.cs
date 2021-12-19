// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_TIER_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_TIER_HEVC"]/*' />
public enum D3D12_VIDEO_ENCODER_TIER_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_TIER_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_TIER_HEVC.D3D12_VIDEO_ENCODER_TIER_HEVC_MAIN"]/*' />
    D3D12_VIDEO_ENCODER_TIER_HEVC_MAIN = 0,

    /// <include file='D3D12_VIDEO_ENCODER_TIER_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_TIER_HEVC.D3D12_VIDEO_ENCODER_TIER_HEVC_HIGH"]/*' />
    D3D12_VIDEO_ENCODER_TIER_HEVC_HIGH = 1,
}