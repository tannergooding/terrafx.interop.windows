// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct D3DCONTENTPROTECTIONCAPS
    {
        [NativeTypeName("DWORD")]
        public uint Caps;

        [NativeTypeName("GUID")]
        public Guid KeyExchangeType;

        [NativeTypeName("UINT")]
        public uint BufferAlignmentStart;

        [NativeTypeName("UINT")]
        public uint BlockAlignmentSize;

        [NativeTypeName("ULONGLONG")]
        public ulong ProtectedMemorySize;
    }
}
