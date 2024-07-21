// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D
{
    [NativeTypeName("#define D3D_MAX_SIMULTANEOUS_RENDERTARGETS 4")]
    public const int D3D_MAX_SIMULTANEOUS_RENDERTARGETS = 4;

    [NativeTypeName("#define D3D_OMAC_SIZE 16")]
    public const int D3D_OMAC_SIZE = 16;
}
