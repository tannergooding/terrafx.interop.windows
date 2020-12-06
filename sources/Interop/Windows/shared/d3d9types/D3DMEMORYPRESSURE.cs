// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct D3DMEMORYPRESSURE
    {
        [NativeTypeName("UINT64")]
        public ulong BytesEvictedFromProcess;

        [NativeTypeName("UINT64")]
        public ulong SizeOfInefficientAllocation;

        [NativeTypeName("DWORD")]
        public uint LevelOfEfficiency;
    }
}
