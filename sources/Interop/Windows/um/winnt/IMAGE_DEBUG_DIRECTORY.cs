// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_DEBUG_DIRECTORY
    {
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        [NativeTypeName("WORD")]
        public ushort MinorVersion;

        [NativeTypeName("DWORD")]
        public uint Type;

        [NativeTypeName("DWORD")]
        public uint SizeOfData;

        [NativeTypeName("DWORD")]
        public uint AddressOfRawData;

        [NativeTypeName("DWORD")]
        public uint PointerToRawData;
    }
}
