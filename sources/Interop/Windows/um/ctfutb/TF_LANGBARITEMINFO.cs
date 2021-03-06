// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct TF_LANGBARITEMINFO
    {
        [NativeTypeName("CLSID")]
        public Guid clsidService;

        [NativeTypeName("GUID")]
        public Guid guidItem;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("ULONG")]
        public uint ulSort;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort szDescription[32];
    }
}
