// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING"]/*' />
public enum D3DSCANLINEORDERING
{
    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_UNKNOWN"]/*' />
    D3DSCANLINEORDERING_UNKNOWN = 0,

    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_PROGRESSIVE"]/*' />
    D3DSCANLINEORDERING_PROGRESSIVE = 1,

    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_INTERLACED"]/*' />
    D3DSCANLINEORDERING_INTERLACED = 2,
}
