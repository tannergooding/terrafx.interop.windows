// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES"]/*' />
public partial struct D3D12_HEAP_PROPERTIES
{
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.Type"]/*' />
    public D3D12_HEAP_TYPE Type;

    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.CPUPageProperty"]/*' />
    public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;

    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.MemoryPoolPreference"]/*' />
    public D3D12_MEMORY_POOL MemoryPoolPreference;

    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.CreationNodeMask"]/*' />
    public uint CreationNodeMask;

    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.VisibleNodeMask"]/*' />
    public uint VisibleNodeMask;
}
