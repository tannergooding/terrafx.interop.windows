// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_BARRIER_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_FLAGS"]/*' />
[Flags]
public enum D3D12_RESOURCE_BARRIER_FLAGS
{
    /// <include file='D3D12_RESOURCE_BARRIER_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_FLAGS.D3D12_RESOURCE_BARRIER_FLAG_NONE"]/*' />
    D3D12_RESOURCE_BARRIER_FLAG_NONE = 0,

    /// <include file='D3D12_RESOURCE_BARRIER_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_FLAGS.D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY"]/*' />
    D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY = 0x1,

    /// <include file='D3D12_RESOURCE_BARRIER_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_FLAGS.D3D12_RESOURCE_BARRIER_FLAG_END_ONLY"]/*' />
    D3D12_RESOURCE_BARRIER_FLAG_END_ONLY = 0x2,
}