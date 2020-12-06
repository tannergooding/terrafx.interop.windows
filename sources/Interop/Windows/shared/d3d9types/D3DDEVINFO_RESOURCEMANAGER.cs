// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3DDEVINFO_RESOURCEMANAGER
    {
        [NativeTypeName("D3DRESOURCESTATS [8]")]
        public _stats_e__FixedBuffer stats;

        public partial struct _stats_e__FixedBuffer
        {
            public D3DRESOURCESTATS e0;
            public D3DRESOURCESTATS e1;
            public D3DRESOURCESTATS e2;
            public D3DRESOURCESTATS e3;
            public D3DRESOURCESTATS e4;
            public D3DRESOURCESTATS e5;
            public D3DRESOURCESTATS e6;
            public D3DRESOURCESTATS e7;

            public ref D3DRESOURCESTATS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3DRESOURCESTATS> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
