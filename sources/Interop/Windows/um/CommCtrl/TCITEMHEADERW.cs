// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TCITEMHEADERW
    {
        [NativeTypeName("UINT")]
        public uint mask;

        [NativeTypeName("UINT")]
        public uint lpReserved1;

        [NativeTypeName("UINT")]
        public uint lpReserved2;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public int cchTextMax;

        public int iImage;
    }
}
