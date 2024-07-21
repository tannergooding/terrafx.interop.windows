// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16"]/*' />
public partial struct EMRPOLYPOLYLINE16
{
    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.emr"]/*' />
    public EMR emr;

    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.nPolys"]/*' />
    [NativeTypeName("DWORD")]
    public uint nPolys;

    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.cpts"]/*' />
    [NativeTypeName("DWORD")]
    public uint cpts;

    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.aPolyCounts"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _aPolyCounts_e__FixedBuffer aPolyCounts;

    /// <include file='EMRPOLYPOLYLINE16.xml' path='doc/member[@name="EMRPOLYPOLYLINE16.apts"]/*' />
    [NativeTypeName("POINTS[1]")]
    public _apts_e__FixedBuffer apts;

    /// <include file='_aPolyCounts_e__FixedBuffer.xml' path='doc/member[@name="_aPolyCounts_e__FixedBuffer"]/*' />
    public partial struct _aPolyCounts_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }

    /// <include file='_apts_e__FixedBuffer.xml' path='doc/member[@name="_apts_e__FixedBuffer"]/*' />
    public partial struct _apts_e__FixedBuffer
    {
        public POINTS e0;

        [UnscopedRef]
        public ref POINTS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
