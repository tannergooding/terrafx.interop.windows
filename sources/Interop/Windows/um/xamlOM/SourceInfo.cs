// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SourceInfo
    {
        [NativeTypeName("BSTR")]
        public ushort* FileName;

        [NativeTypeName("unsigned int")]
        public uint LineNumber;

        [NativeTypeName("unsigned int")]
        public uint ColumnNumber;

        [NativeTypeName("unsigned int")]
        public uint CharPosition;

        [NativeTypeName("BSTR")]
        public ushort* Hash;
    }
}
