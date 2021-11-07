// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct PACKAGE_VERSION
    {
        [NativeTypeName("PACKAGE_VERSION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmodel.h:57:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ulong Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Version, 1));
            }
        }

        public ref ushort Revision
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Revision, 1));
            }
        }

        public ref ushort Build
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Build, 1));
            }
        }

        public ref ushort Minor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Minor, 1));
            }
        }

        public ref ushort Major
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Major, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit, Pack = 4)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong Version;

            [FieldOffset(0)]
            [NativeTypeName("PACKAGE_VERSION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmodel.h:59:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ushort Revision;

                public ushort Build;

                public ushort Minor;

                public ushort Major;
            }
        }
    }
}
