// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW"]/*' />
public unsafe partial struct OPEN_PRINTER_PROPS_INFOW
{
    /// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW.pszSheetName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszSheetName;

    /// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW.uSheetIndex"]/*' />
    public uint uSheetIndex;

    /// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='OPEN_PRINTER_PROPS_INFOW.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOW.bModal"]/*' />
    public BOOL bModal;
}
