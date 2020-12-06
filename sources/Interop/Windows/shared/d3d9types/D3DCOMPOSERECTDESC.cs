// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DCOMPOSERECTDESC
    {
        [NativeTypeName("USHORT")]
        public ushort X;

        [NativeTypeName("USHORT")]
        public ushort Y;

        [NativeTypeName("USHORT")]
        public ushort Width;

        [NativeTypeName("USHORT")]
        public ushort Height;
    }
}
