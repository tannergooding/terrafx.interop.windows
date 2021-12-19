// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_COLOR_RGBA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_RGBA"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_VIDEO_COLOR_RGBA
{
    /// <include file='D3D11_VIDEO_COLOR_RGBA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_RGBA.R"]/*' />
    public float R;

    /// <include file='D3D11_VIDEO_COLOR_RGBA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_RGBA.G"]/*' />
    public float G;

    /// <include file='D3D11_VIDEO_COLOR_RGBA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_RGBA.B"]/*' />
    public float B;

    /// <include file='D3D11_VIDEO_COLOR_RGBA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_RGBA.A"]/*' />
    public float A;
}
