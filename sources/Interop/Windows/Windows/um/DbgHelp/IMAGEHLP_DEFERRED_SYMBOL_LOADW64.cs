// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64"]/*' />
public partial struct IMAGEHLP_DEFERRED_SYMBOL_LOADW64
{
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.BaseOfImage"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.FileName"]/*' />
    [NativeTypeName("WCHAR[261]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.Reparse"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Reparse;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.hFile"]/*' />
    public HANDLE hFile;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOADW64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOADW64.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [InlineArray(261)]
    public partial struct _FileName_e__FixedBuffer
    {
        public char e0;
    }
}
