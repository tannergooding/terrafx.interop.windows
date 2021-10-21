// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct GROUP_SOURCE_REQ
    {
        [NativeTypeName("ULONG")]
        public uint gsr_interface;

        public SOCKADDR_STORAGE gsr_group;

        public SOCKADDR_STORAGE gsr_source;
    }
}