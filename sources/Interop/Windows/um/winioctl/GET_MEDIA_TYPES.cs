// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct GET_MEDIA_TYPES
    {
        [NativeTypeName("DWORD")]
        public uint DeviceType;

        [NativeTypeName("DWORD")]
        public uint MediaInfoCount;

        [NativeTypeName("DEVICE_MEDIA_INFO [1]")]
        public _MediaInfo_e__FixedBuffer MediaInfo;

        public partial struct _MediaInfo_e__FixedBuffer
        {
            public DEVICE_MEDIA_INFO e0;

            public ref DEVICE_MEDIA_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<DEVICE_MEDIA_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
