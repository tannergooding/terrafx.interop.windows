// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIDIPROPTIMEDIV.xml' path='doc/member[@name="MIDIPROPTIMEDIV"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIPROPTIMEDIV
{
    /// <include file='MIDIPROPTIMEDIV.xml' path='doc/member[@name="MIDIPROPTIMEDIV.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIDIPROPTIMEDIV.xml' path='doc/member[@name="MIDIPROPTIMEDIV.dwTimeDiv"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTimeDiv;
}