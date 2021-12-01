// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='AUTHENTICATEINFO.xml' path='doc/member[@name="AUTHENTICATEINFO"]/*' />
public partial struct AUTHENTICATEINFO
{
    /// <include file='AUTHENTICATEINFO.xml' path='doc/member[@name="AUTHENTICATEINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='AUTHENTICATEINFO.xml' path='doc/member[@name="AUTHENTICATEINFO.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}