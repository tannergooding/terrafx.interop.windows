// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("DWORDLONG")]
        public ulong TokenOffset;

        public STORAGE_OFFLOAD_TOKEN Token;
    }
}
