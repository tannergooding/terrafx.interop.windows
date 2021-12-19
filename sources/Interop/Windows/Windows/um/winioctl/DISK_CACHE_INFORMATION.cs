// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION"]/*' />
public partial struct DISK_CACHE_INFORMATION
{
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ParametersSavable"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ParametersSavable;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ReadCacheEnabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ReadCacheEnabled;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.WriteCacheEnabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte WriteCacheEnabled;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ReadRetentionPriority"]/*' />
    public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.WriteRetentionPriority"]/*' />
    public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.DisablePrefetchTransferLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort DisablePrefetchTransferLength;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.PrefetchScalar"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte PrefetchScalar;

    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.Anonymous"]/*' />
    [NativeTypeName("_DISK_CACHE_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9441:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ScalarPrefetch"]/*' />
    public ref _Anonymous_e__Union._ScalarPrefetch_e__Struct ScalarPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ScalarPrefetch, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BlockPrefetch"]/*' />
    public ref _Anonymous_e__Union._BlockPrefetch_e__Struct BlockPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.BlockPrefetch, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ScalarPrefetch"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9442:9)")]
        public _ScalarPrefetch_e__Struct ScalarPrefetch;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BlockPrefetch"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:9454:9)")]
        public _BlockPrefetch_e__Struct BlockPrefetch;

        /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct"]/*' />
        public partial struct _ScalarPrefetch_e__Struct
        {
            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.Minimum"]/*' />
            [NativeTypeName("WORD")]
            public ushort Minimum;

            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.Maximum"]/*' />
            [NativeTypeName("WORD")]
            public ushort Maximum;

            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.MaximumBlocks"]/*' />
            [NativeTypeName("WORD")]
            public ushort MaximumBlocks;
        }

        /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct"]/*' />
        public partial struct _BlockPrefetch_e__Struct
        {
            /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct.Minimum"]/*' />
            [NativeTypeName("WORD")]
            public ushort Minimum;

            /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct.Maximum"]/*' />
            [NativeTypeName("WORD")]
            public ushort Maximum;
        }
    }
}
