// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FontWeight.xml' path='doc/member[@name="FontWeight"]/*' />
public partial struct FontWeight
{
    /// <include file='FontWeight.xml' path='doc/member[@name="FontWeight.Weight"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Weight;
}
