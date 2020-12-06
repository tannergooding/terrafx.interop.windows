// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DRESOURCESTATS
    {
        [NativeTypeName("BOOL")]
        public int bThrashing;

        [NativeTypeName("DWORD")]
        public uint ApproxBytesDownloaded;

        [NativeTypeName("DWORD")]
        public uint NumEvicts;

        [NativeTypeName("DWORD")]
        public uint NumVidCreates;

        [NativeTypeName("DWORD")]
        public uint LastPri;

        [NativeTypeName("DWORD")]
        public uint NumUsed;

        [NativeTypeName("DWORD")]
        public uint NumUsedInVidMem;

        [NativeTypeName("DWORD")]
        public uint WorkingSet;

        [NativeTypeName("DWORD")]
        public uint WorkingSetBytes;

        [NativeTypeName("DWORD")]
        public uint TotalManaged;

        [NativeTypeName("DWORD")]
        public uint TotalBytes;
    }
}
