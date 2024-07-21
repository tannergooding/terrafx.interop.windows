// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.InitialQP"]/*' />
    public uint InitialQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.MinQP"]/*' />
    public uint MinQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.MaxQP"]/*' />
    public uint MaxQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.MaxFrameBitSize"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaxFrameBitSize;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.TargetAvgBitRate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TargetAvgBitRate;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.PeakBitRate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PeakBitRate;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.ConstantQualityTarget"]/*' />
    public uint ConstantQualityTarget;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.VBVCapacity"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VBVCapacity;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.InitialVBVFullness"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InitialVBVFullness;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1.QualityVsSpeed"]/*' />
    public uint QualityVsSpeed;
}
