// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8 = 0,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16 = 1,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32 = 2,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64 = 3,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8 = 4,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16 = 5,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32 = 6,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64 = 7,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT = 8,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE = 9,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE = 10,
}
