// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION"]/*' />
public partial struct WOW64_ARCHITECTURE_INFORMATION
{
    public uint _bitfield;

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Machine"]/*' />
    [NativeTypeName("DWORD : 16")]
    public uint Machine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0xFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
        }
    }

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.KernelMode"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint KernelMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 16) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
        }
    }

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.UserMode"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint UserMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 17) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
        }
    }

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Native"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint Native
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 18) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
        }
    }

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.Process"]/*' />
    [NativeTypeName("DWORD : 1")]
    public uint Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 19) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
        }
    }

    /// <include file='WOW64_ARCHITECTURE_INFORMATION.xml' path='doc/member[@name="WOW64_ARCHITECTURE_INFORMATION.ReservedZero0"]/*' />
    [NativeTypeName("DWORD : 12")]
    public uint ReservedZero0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 20) & 0xFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
        }
    }
}
