// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct QUERY_BAD_RANGES_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint NumBadRanges;

        [NativeTypeName("DWORDLONG")]
        public ulong NextOffsetToLookUp;

        [NativeTypeName("QUERY_BAD_RANGES_OUTPUT_RANGE [1]")]
        public _BadRanges_e__FixedBuffer BadRanges;

        public partial struct _BadRanges_e__FixedBuffer
        {
            public QUERY_BAD_RANGES_OUTPUT_RANGE e0;

            public ref QUERY_BAD_RANGES_OUTPUT_RANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<QUERY_BAD_RANGES_OUTPUT_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
