// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_SPEC_VERSION.xml' path='doc/member[@name="STORAGE_SPEC_VERSION"]/*' />
[StructLayout(LayoutKind.Explicit)]
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_SPEC_VERSION
{
    /// <include file='STORAGE_SPEC_VERSION.xml' path='doc/member[@name="STORAGE_SPEC_VERSION.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("_STORAGE_SPEC_VERSION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2503:5)")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='STORAGE_SPEC_VERSION.xml' path='doc/member[@name="STORAGE_SPEC_VERSION.AsUlong"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint AsUlong;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinorVersion"]/*' />
    public ref _Anonymous_e__Struct._MinorVersion_e__Union MinorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MinorVersion, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MajorVersion"]/*' />
    public ref ushort MajorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.MajorVersion, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinorVersion"]/*' />
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2504:9)")]
        public _MinorVersion_e__Union MinorVersion;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MajorVersion"]/*' />
        [NativeTypeName("WORD")]
        public ushort MajorVersion;

        /// <include file='_MinorVersion_e__Union.xml' path='doc/member[@name="_MinorVersion_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _MinorVersion_e__Union
        {
            /// <include file='_MinorVersion_e__Union.xml' path='doc/member[@name="_MinorVersion_e__Union.Anonymous"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("_STORAGE_SPEC_VERSION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:2505:13)")]
            public _Anonymous_e__Struct Anonymous;

            /// <include file='_MinorVersion_e__Union.xml' path='doc/member[@name="_MinorVersion_e__Union.AsUshort"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("WORD")]
            public ushort AsUshort;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SubMinor"]/*' />
            public ref byte SubMinor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SubMinor, 1));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Minor"]/*' />
            public ref byte Minor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Minor, 1));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
            public partial struct _Anonymous_e__Struct
            {
                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SubMinor"]/*' />
                public byte SubMinor;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Minor"]/*' />
                public byte Minor;
            }
        }
    }
}