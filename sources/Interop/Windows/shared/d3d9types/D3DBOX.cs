// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DBOX
    {
        [NativeTypeName("UINT")]
        public uint Left;

        [NativeTypeName("UINT")]
        public uint Top;

        [NativeTypeName("UINT")]
        public uint Right;

        [NativeTypeName("UINT")]
        public uint Bottom;

        [NativeTypeName("UINT")]
        public uint Front;

        [NativeTypeName("UINT")]
        public uint Back;
    }
}
