// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DOVERLAYCAPS
    {
        [NativeTypeName("UINT")]
        public uint Caps;

        [NativeTypeName("UINT")]
        public uint MaxOverlayDisplayWidth;

        [NativeTypeName("UINT")]
        public uint MaxOverlayDisplayHeight;
    }
}
