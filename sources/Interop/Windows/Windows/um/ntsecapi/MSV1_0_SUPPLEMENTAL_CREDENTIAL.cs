// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL"]/*' />
public partial struct MSV1_0_SUPPLEMENTAL_CREDENTIAL
{
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.LmPassword"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public _LmPassword_e__FixedBuffer LmPassword;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.NtPassword"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public _NtPassword_e__FixedBuffer NtPassword;

    /// <include file='_LmPassword_e__FixedBuffer.xml' path='doc/member[@name="_LmPassword_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _LmPassword_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_NtPassword_e__FixedBuffer.xml' path='doc/member[@name="_NtPassword_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _NtPassword_e__FixedBuffer
    {
        public byte e0;
    }
}
