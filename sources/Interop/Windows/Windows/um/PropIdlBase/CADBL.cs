// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CADBL.xml' path='doc/member[@name="CADBL"]/*' />
public unsafe partial struct CADBL
{
    /// <include file='CADBL.xml' path='doc/member[@name="CADBL.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CADBL.xml' path='doc/member[@name="CADBL.pElems"]/*' />
    public double* pElems;
}
