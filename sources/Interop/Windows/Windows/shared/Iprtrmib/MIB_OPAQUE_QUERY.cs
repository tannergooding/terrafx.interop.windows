// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY"]/*' />
public partial struct MIB_OPAQUE_QUERY
{
    /// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY.dwVarId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVarId;

    /// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY.rgdwVarIndex"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _rgdwVarIndex_e__FixedBuffer rgdwVarIndex;

    /// <include file='_rgdwVarIndex_e__FixedBuffer.xml' path='doc/member[@name="_rgdwVarIndex_e__FixedBuffer"]/*' />
    public partial struct _rgdwVarIndex_e__FixedBuffer
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
}
