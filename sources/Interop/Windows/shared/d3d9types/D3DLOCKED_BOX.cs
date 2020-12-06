// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3DLOCKED_BOX
    {
        [NativeTypeName("INT")]
        public int RowPitch;

        [NativeTypeName("INT")]
        public int SlicePitch;

        [NativeTypeName("void *")]
        public void* pBits;
    }
}
