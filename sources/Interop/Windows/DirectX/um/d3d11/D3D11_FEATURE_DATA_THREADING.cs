// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE_DATA_THREADING.xml' path='doc/member[@name="D3D11_FEATURE_DATA_THREADING"]/*' />
public partial struct D3D11_FEATURE_DATA_THREADING
{
    /// <include file='D3D11_FEATURE_DATA_THREADING.xml' path='doc/member[@name="D3D11_FEATURE_DATA_THREADING.DriverConcurrentCreates"]/*' />
    public BOOL DriverConcurrentCreates;

    /// <include file='D3D11_FEATURE_DATA_THREADING.xml' path='doc/member[@name="D3D11_FEATURE_DATA_THREADING.DriverCommandLists"]/*' />
    public BOOL DriverCommandLists;
}
