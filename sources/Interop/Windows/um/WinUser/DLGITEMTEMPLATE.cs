// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct DLGITEMTEMPLATE
    {
        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("DWORD")]
        public uint dwExtendedStyle;

        public short x;

        public short y;

        public short cx;

        public short cy;

        [NativeTypeName("WORD")]
        public ushort id;
    }
}
