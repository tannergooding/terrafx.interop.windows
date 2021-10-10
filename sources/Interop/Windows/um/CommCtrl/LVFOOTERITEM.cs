// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVFOOTERITEM
    {
        [NativeTypeName("UINT")]
        public uint mask;

        public int iItem;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public int cchTextMax;

        [NativeTypeName("UINT")]
        public uint state;

        [NativeTypeName("UINT")]
        public uint stateMask;
    }
}
