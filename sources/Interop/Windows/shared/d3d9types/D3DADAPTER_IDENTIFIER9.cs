// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct D3DADAPTER_IDENTIFIER9
    {
        [NativeTypeName("char [512]")]
        public fixed sbyte Driver[512];

        [NativeTypeName("char [512]")]
        public fixed sbyte Description[512];

        [NativeTypeName("char [32]")]
        public fixed sbyte DeviceName[32];

        public LARGE_INTEGER DriverVersion;

        [NativeTypeName("DWORD")]
        public uint VendorId;

        [NativeTypeName("DWORD")]
        public uint DeviceId;

        [NativeTypeName("DWORD")]
        public uint SubSysId;

        [NativeTypeName("DWORD")]
        public uint Revision;

        [NativeTypeName("GUID")]
        public Guid DeviceIdentifier;

        [NativeTypeName("DWORD")]
        public uint WHQLLevel;
    }
}
