// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DVERTEXELEMENT9
    {
        [NativeTypeName("WORD")]
        public ushort Stream;

        [NativeTypeName("WORD")]
        public ushort Offset;

        [NativeTypeName("BYTE")]
        public byte Type;

        [NativeTypeName("BYTE")]
        public byte Method;

        [NativeTypeName("BYTE")]
        public byte Usage;

        [NativeTypeName("BYTE")]
        public byte UsageIndex;
    }
}
