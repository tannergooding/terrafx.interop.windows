// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC"]/*' />
public unsafe partial struct PROPSPEC
{
    /// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC.ulKind"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulKind;

    /// <include file='PROPSPEC.xml' path='doc/member[@name="PROPSPEC.Anonymous"]/*' />
    [NativeTypeName("tagPROPSPEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/PropIdlBase.h:452:43)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.propid"]/*' />
    public ref uint propid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.propid, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpwstr"]/*' />
    public ref ushort* lpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.lpwstr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.propid"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PROPID")]
        public uint propid;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lpwstr"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* lpwstr;
    }
}