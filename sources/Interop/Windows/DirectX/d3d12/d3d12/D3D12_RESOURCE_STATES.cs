// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES"]/*' />
[Flags]
public enum D3D12_RESOURCE_STATES
{
    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COMMON"]/*' />
    D3D12_RESOURCE_STATE_COMMON = 0,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER"]/*' />
    D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER = 0x1,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_INDEX_BUFFER"]/*' />
    D3D12_RESOURCE_STATE_INDEX_BUFFER = 0x2,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RENDER_TARGET"]/*' />
    D3D12_RESOURCE_STATE_RENDER_TARGET = 0x4,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_UNORDERED_ACCESS"]/*' />
    D3D12_RESOURCE_STATE_UNORDERED_ACCESS = 0x8,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_DEPTH_WRITE"]/*' />
    D3D12_RESOURCE_STATE_DEPTH_WRITE = 0x10,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_DEPTH_READ"]/*' />
    D3D12_RESOURCE_STATE_DEPTH_READ = 0x20,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE"]/*' />
    D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE = 0x40,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE"]/*' />
    D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE = 0x80,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_STREAM_OUT"]/*' />
    D3D12_RESOURCE_STATE_STREAM_OUT = 0x100,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT"]/*' />
    D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT = 0x200,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COPY_DEST"]/*' />
    D3D12_RESOURCE_STATE_COPY_DEST = 0x400,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COPY_SOURCE"]/*' />
    D3D12_RESOURCE_STATE_COPY_SOURCE = 0x800,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESOLVE_DEST"]/*' />
    D3D12_RESOURCE_STATE_RESOLVE_DEST = 0x1000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESOLVE_SOURCE"]/*' />
    D3D12_RESOURCE_STATE_RESOLVE_SOURCE = 0x2000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE"]/*' />
    D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE = 0x400000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE"]/*' />
    D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE = 0x1000000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_8000"]/*' />
    D3D12_RESOURCE_STATE_RESERVED_INTERNAL_8000 = 0x8000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_4000"]/*' />
    D3D12_RESOURCE_STATE_RESERVED_INTERNAL_4000 = 0x4000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_100000"]/*' />
    D3D12_RESOURCE_STATE_RESERVED_INTERNAL_100000 = 0x100000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_40000000"]/*' />
    D3D12_RESOURCE_STATE_RESERVED_INTERNAL_40000000 = 0x40000000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_80000000"]/*' />
    D3D12_RESOURCE_STATE_RESERVED_INTERNAL_80000000 = unchecked((int)(0x80000000)),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_GENERIC_READ"]/*' />
    D3D12_RESOURCE_STATE_GENERIC_READ = (((((0x1 | 0x2) | 0x40) | 0x80) | 0x200) | 0x800),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE"]/*' />
    D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE = (0x40 | 0x80),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PRESENT"]/*' />
    D3D12_RESOURCE_STATE_PRESENT = 0,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PREDICATION"]/*' />
    D3D12_RESOURCE_STATE_PREDICATION = 0x200,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_DECODE_READ"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_DECODE_READ = 0x10000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE = 0x20000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ = 0x40000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE = 0x80000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ = 0x200000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE"]/*' />
    D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE = 0x800000,
}
