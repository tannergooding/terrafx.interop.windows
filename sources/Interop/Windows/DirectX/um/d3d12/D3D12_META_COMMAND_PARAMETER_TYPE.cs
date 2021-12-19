// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE"]/*' />
public enum D3D12_META_COMMAND_PARAMETER_TYPE
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_FLOAT"]/*' />
    D3D12_META_COMMAND_PARAMETER_TYPE_FLOAT = 0,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_UINT64"]/*' />
    D3D12_META_COMMAND_PARAMETER_TYPE_UINT64 = 1,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_GPU_VIRTUAL_ADDRESS"]/*' />
    D3D12_META_COMMAND_PARAMETER_TYPE_GPU_VIRTUAL_ADDRESS = 2,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_CPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV"]/*' />
    D3D12_META_COMMAND_PARAMETER_TYPE_CPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV = 3,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_GPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV"]/*' />
    D3D12_META_COMMAND_PARAMETER_TYPE_GPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV = 4,
}
