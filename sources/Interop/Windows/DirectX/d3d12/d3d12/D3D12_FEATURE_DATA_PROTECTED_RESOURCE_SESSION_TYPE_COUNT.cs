// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT"]/*' />
public partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT
{
    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT.Count"]/*' />
    public uint Count;
}