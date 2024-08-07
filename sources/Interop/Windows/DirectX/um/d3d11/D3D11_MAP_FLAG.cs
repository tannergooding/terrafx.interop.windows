// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_MAP_FLAG.xml' path='doc/member[@name="D3D11_MAP_FLAG"]/*' />
[Flags]
public enum D3D11_MAP_FLAG
{
    /// <include file='D3D11_MAP_FLAG.xml' path='doc/member[@name="D3D11_MAP_FLAG.D3D11_MAP_FLAG_DO_NOT_WAIT"]/*' />
    D3D11_MAP_FLAG_DO_NOT_WAIT = 0x100000,
}
