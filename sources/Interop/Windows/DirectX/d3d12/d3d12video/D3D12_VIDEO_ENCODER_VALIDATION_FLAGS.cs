// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS"]/*' />
public enum D3D12_VIDEO_ENCODER_VALIDATION_FLAGS
{
    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_NONE"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_NOT_SUPPORTED = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INPUT_FORMAT_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INPUT_FORMAT_NOT_SUPPORTED = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_CONFIGURATION_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_CONFIGURATION_NOT_SUPPORTED = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_MODE_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_MODE_NOT_SUPPORTED = 0x20,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_CONFIGURATION_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_CONFIGURATION_NOT_SUPPORTED = 0x40,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INTRA_REFRESH_MODE_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INTRA_REFRESH_MODE_NOT_SUPPORTED = 0x80,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_MODE_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_MODE_NOT_SUPPORTED = 0x100,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RESOLUTION_NOT_SUPPORTED_IN_LIST"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RESOLUTION_NOT_SUPPORTED_IN_LIST = 0x200,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_GOP_STRUCTURE_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_GOP_STRUCTURE_NOT_SUPPORTED = 0x800,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_DATA_NOT_SUPPORTED"]/*' />
    D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_DATA_NOT_SUPPORTED = 0x1000,
}