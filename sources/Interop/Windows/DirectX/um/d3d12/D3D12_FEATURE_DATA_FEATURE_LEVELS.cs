// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_FEATURE_LEVELS
{
    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.NumFeatureLevels"]/*' />
    public uint NumFeatureLevels;

    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.pFeatureLevelsRequested"]/*' />
    [NativeTypeName("const D3D_FEATURE_LEVEL *")]
    public D3D_FEATURE_LEVEL* pFeatureLevelsRequested;

    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.MaxSupportedFeatureLevel"]/*' />
    public D3D_FEATURE_LEVEL MaxSupportedFeatureLevel;
}
