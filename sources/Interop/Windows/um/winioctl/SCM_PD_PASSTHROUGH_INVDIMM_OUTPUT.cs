// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT
    {
        [NativeTypeName("WORD")]
        public ushort GeneralStatus;

        [NativeTypeName("WORD")]
        public ushort ExtendedStatus;

        [NativeTypeName("DWORD")]
        public uint OutputDataLength;

        [NativeTypeName("BYTE [1]")]
        public fixed byte OutputData[1];
    }
}
