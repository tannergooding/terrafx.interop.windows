// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_QUERY_MISC_FLAG.xml' path='doc/member[@name="D3D11_QUERY_MISC_FLAG"]/*' />
[Flags]
public enum D3D11_QUERY_MISC_FLAG
{
    /// <include file='D3D11_QUERY_MISC_FLAG.xml' path='doc/member[@name="D3D11_QUERY_MISC_FLAG.D3D11_QUERY_MISC_PREDICATEHINT"]/*' />
    D3D11_QUERY_MISC_PREDICATEHINT = 0x1,
}
