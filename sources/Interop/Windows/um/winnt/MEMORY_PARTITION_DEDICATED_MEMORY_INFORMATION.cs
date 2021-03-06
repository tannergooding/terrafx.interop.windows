// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint NextEntryOffset;

        [NativeTypeName("DWORD")]
        public uint SizeOfInformation;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint AttributesOffset;

        [NativeTypeName("DWORD")]
        public uint AttributeCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("DWORD64")]
        public ulong TypeId;
    }
}
