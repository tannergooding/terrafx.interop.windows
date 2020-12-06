// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3DGAMMARAMP
    {
        [NativeTypeName("WORD [256]")]
        public fixed ushort red[256];

        [NativeTypeName("WORD [256]")]
        public fixed ushort green[256];

        [NativeTypeName("WORD [256]")]
        public fixed ushort blue[256];
    }
}
