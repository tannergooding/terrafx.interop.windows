// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PERSISTENT_RESERVE_COMMAND.xml' path='doc/member[@name="PERSISTENT_RESERVE_COMMAND"]/*' />
public partial struct PERSISTENT_RESERVE_COMMAND
{
    /// <include file='PERSISTENT_RESERVE_COMMAND.xml' path='doc/member[@name="PERSISTENT_RESERVE_COMMAND.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='PERSISTENT_RESERVE_COMMAND.xml' path='doc/member[@name="PERSISTENT_RESERVE_COMMAND.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='PERSISTENT_RESERVE_COMMAND.xml' path='doc/member[@name="PERSISTENT_RESERVE_COMMAND.Anonymous"]/*' />
    [NativeTypeName("_PERSISTENT_RESERVE_COMMAND::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:5770:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PR_IN"]/*' />
    public ref _Anonymous_e__Union._PR_IN_e__Struct PR_IN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.PR_IN, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PR_OUT"]/*' />
    public ref _Anonymous_e__Union._PR_OUT_e__Struct PR_OUT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.PR_OUT, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PR_IN"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:5772:9)")]
        public _PR_IN_e__Struct PR_IN;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PR_OUT"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:5789:9)")]
        public _PR_OUT_e__Struct PR_OUT;

        /// <include file='_PR_IN_e__Struct.xml' path='doc/member[@name="_PR_IN_e__Struct"]/*' />
        public partial struct _PR_IN_e__Struct
        {
            public byte _bitfield;

            /// <include file='_PR_IN_e__Struct.xml' path='doc/member[@name="_PR_IN_e__Struct.ServiceAction"]/*' />
            [NativeTypeName("byte : 5")]
            public byte ServiceAction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)(_bitfield & 0x1Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~0x1Fu) | (value & 0x1Fu));
                }
            }

            /// <include file='_PR_IN_e__Struct.xml' path='doc/member[@name="_PR_IN_e__Struct.Reserved1"]/*' />
            [NativeTypeName("byte : 3")]
            public byte Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)((_bitfield >> 5) & 0x7u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5));
                }
            }

            /// <include file='_PR_IN_e__Struct.xml' path='doc/member[@name="_PR_IN_e__Struct.AllocationLength"]/*' />
            [NativeTypeName("WORD")]
            public ushort AllocationLength;
        }

        /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct"]/*' />
        public unsafe partial struct _PR_OUT_e__Struct
        {
            public byte _bitfield1;

            /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct.ServiceAction"]/*' />
            [NativeTypeName("byte : 5")]
            public byte ServiceAction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)(_bitfield1 & 0x1Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield1 = (byte)((_bitfield1 & ~0x1Fu) | (value & 0x1Fu));
                }
            }

            /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct.Reserved1"]/*' />
            [NativeTypeName("byte : 3")]
            public byte Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)((_bitfield1 >> 5) & 0x7u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield1 = (byte)((_bitfield1 & ~(0x7u << 5)) | ((value & 0x7u) << 5));
                }
            }

            public byte _bitfield2;

            /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct.Type"]/*' />
            [NativeTypeName("byte : 4")]
            public byte Type
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)(_bitfield2 & 0xFu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu));
                }
            }

            /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct.Scope"]/*' />
            [NativeTypeName("byte : 4")]
            public byte Scope
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (byte)((_bitfield2 >> 4) & 0xFu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
                }
            }

            /// <include file='_PR_OUT_e__Struct.xml' path='doc/member[@name="_PR_OUT_e__Struct.ParameterList"]/*' />
            [NativeTypeName("BYTE [0]")]
            public fixed byte ParameterList[1];
        }
    }
}
