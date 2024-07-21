// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB"]/*' />
public partial struct FLAGGED_BYTE_BLOB
{
    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.fFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint fFlags;

    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.abData"]/*' />
    [NativeTypeName("byte[1]")]
    public _abData_e__FixedBuffer abData;

    /// <include file='_abData_e__FixedBuffer.xml' path='doc/member[@name="_abData_e__FixedBuffer"]/*' />
    public partial struct _abData_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
