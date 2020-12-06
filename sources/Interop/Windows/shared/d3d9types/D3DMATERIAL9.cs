// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DMATERIAL9
    {
        [NativeTypeName("D3DCOLORVALUE")]
        public DXGI_RGBA Diffuse;

        [NativeTypeName("D3DCOLORVALUE")]
        public DXGI_RGBA Ambient;

        [NativeTypeName("D3DCOLORVALUE")]
        public DXGI_RGBA Specular;

        [NativeTypeName("D3DCOLORVALUE")]
        public DXGI_RGBA Emissive;

        public float Power;
    }
}
