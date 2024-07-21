// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCAPS2A
{
    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
