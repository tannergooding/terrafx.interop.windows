// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_COLOR_YCbCrA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_YCbCrA"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_COLOR_YCbCrA
{
    /// <include file='D3D11_VIDEO_COLOR_YCbCrA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_YCbCrA.Y"]/*' />
    public float Y;

    /// <include file='D3D11_VIDEO_COLOR_YCbCrA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_YCbCrA.Cb"]/*' />
    public float Cb;

    /// <include file='D3D11_VIDEO_COLOR_YCbCrA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_YCbCrA.Cr"]/*' />
    public float Cr;

    /// <include file='D3D11_VIDEO_COLOR_YCbCrA.xml' path='doc/member[@name="D3D11_VIDEO_COLOR_YCbCrA.A"]/*' />
    public float A;
}
