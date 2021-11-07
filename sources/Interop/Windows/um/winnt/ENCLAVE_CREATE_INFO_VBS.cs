// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.16299.0")]
    public unsafe partial struct ENCLAVE_CREATE_INFO_VBS
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("BYTE [32]")]
        public fixed byte OwnerID[32];
    }
}
