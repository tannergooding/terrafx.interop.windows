// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SHChangeProductKeyAsIDList
    {
        [NativeTypeName("USHORT")]
        public ushort cb;

        [NativeTypeName("WCHAR [39]")]
        public fixed ushort wszProductKey[39];

        [NativeTypeName("USHORT")]
        public ushort cbZero;
    }
}