// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY"]/*' />
public partial struct STORAGE_PROPERTY_QUERY
{
    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.PropertyId"]/*' />
    public STORAGE_PROPERTY_ID PropertyId;

    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.QueryType"]/*' />
    public STORAGE_QUERY_TYPE QueryType;

    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.AdditionalParameters"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _AdditionalParameters_e__FixedBuffer AdditionalParameters;

    /// <include file='_AdditionalParameters_e__FixedBuffer.xml' path='doc/member[@name="_AdditionalParameters_e__FixedBuffer"]/*' />
    public partial struct _AdditionalParameters_e__FixedBuffer
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
