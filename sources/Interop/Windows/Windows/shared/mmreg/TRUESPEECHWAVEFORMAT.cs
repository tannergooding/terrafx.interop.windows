// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TRUESPEECHWAVEFORMAT
{
    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.wRevision"]/*' />
    [NativeTypeName("WORD")]
    public ushort wRevision;

    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.nSamplesPerBlock"]/*' />
    [NativeTypeName("WORD")]
    public ushort nSamplesPerBlock;

    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.abReserved"]/*' />
    [NativeTypeName("BYTE[28]")]
    public _abReserved_e__FixedBuffer abReserved;

    /// <include file='_abReserved_e__FixedBuffer.xml' path='doc/member[@name="_abReserved_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(28)]
    public partial struct _abReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
