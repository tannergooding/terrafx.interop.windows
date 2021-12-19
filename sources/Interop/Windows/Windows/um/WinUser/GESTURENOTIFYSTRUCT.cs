// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT"]/*' />
public partial struct GESTURENOTIFYSTRUCT
{
    /// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT.cbSize"]/*' />
    public uint cbSize;

    /// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT.hwndTarget"]/*' />
    public HWND hwndTarget;

    /// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT.ptsLocation"]/*' />
    public POINTS ptsLocation;

    /// <include file='GESTURENOTIFYSTRUCT.xml' path='doc/member[@name="GESTURENOTIFYSTRUCT.dwInstanceID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInstanceID;
}
