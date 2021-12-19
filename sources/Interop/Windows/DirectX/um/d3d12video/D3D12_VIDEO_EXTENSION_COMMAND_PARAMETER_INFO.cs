// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Type"]/*' />
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE Type;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Flags"]/*' />
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS Flags;
}
