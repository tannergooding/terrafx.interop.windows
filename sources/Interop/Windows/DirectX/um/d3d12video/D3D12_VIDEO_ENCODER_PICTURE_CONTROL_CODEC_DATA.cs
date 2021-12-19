// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12video.h:6941:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264PicData"]/*' />
    public ref D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264* pH264PicData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pH264PicData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCPicData"]/*' />
    public ref D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC* pHEVCPicData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pHEVCPicData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264PicData"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264* pH264PicData;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCPicData"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC* pHEVCPicData;
    }
}