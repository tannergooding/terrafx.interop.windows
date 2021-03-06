// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_BASIC_INFO
    {
        public LARGE_INTEGER CreationTime;

        public LARGE_INTEGER LastAccessTime;

        public LARGE_INTEGER LastWriteTime;

        public LARGE_INTEGER ChangeTime;

        [NativeTypeName("DWORD")]
        public uint FileAttributes;
    }
}
