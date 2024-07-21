// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IppResolutionUnit.xml' path='doc/member[@name="IppResolutionUnit"]/*' />
public enum IppResolutionUnit
{
    /// <include file='IppResolutionUnit.xml' path='doc/member[@name="IppResolutionUnit.IppResolutionUnit_DotsPerInch"]/*' />
    IppResolutionUnit_DotsPerInch = 0,

    /// <include file='IppResolutionUnit.xml' path='doc/member[@name="IppResolutionUnit.IppResolutionUnit_DotsPerCentimeter"]/*' />
    IppResolutionUnit_DotsPerCentimeter = 1,
}
