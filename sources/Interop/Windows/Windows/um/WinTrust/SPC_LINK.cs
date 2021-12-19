// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK"]/*' />
public unsafe partial struct SPC_LINK
{
    /// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK.dwLinkChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLinkChoice;

    /// <include file='SPC_LINK.xml' path='doc/member[@name="SPC_LINK.Anonymous"]/*' />
    [NativeTypeName("SPC_LINK_::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WinTrust.h:1280:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszUrl"]/*' />
    public ref ushort* pwszUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pwszUrl;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Moniker"]/*' />
    public ref SPC_SERIALIZED_OBJECT Moniker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Moniker, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszFile"]/*' />
    public ref ushort* pwszFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pwszFile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszUrl"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszUrl;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Moniker"]/*' />
        [FieldOffset(0)]
        public SPC_SERIALIZED_OBJECT Moniker;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszFile"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszFile;
    }
}
