// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardAppletIdGroupActivationPolicy.xml' path='doc/member[@name="SmartCardAppletIdGroupActivationPolicy"]/*' />
public enum SmartCardAppletIdGroupActivationPolicy
{
    /// <include file='SmartCardAppletIdGroupActivationPolicy.xml' path='doc/member[@name="SmartCardAppletIdGroupActivationPolicy.SmartCardAppletIdGroupActivationPolicy_Disabled"]/*' />
    SmartCardAppletIdGroupActivationPolicy_Disabled = 0,

    /// <include file='SmartCardAppletIdGroupActivationPolicy.xml' path='doc/member[@name="SmartCardAppletIdGroupActivationPolicy.SmartCardAppletIdGroupActivationPolicy_ForegroundOverride"]/*' />
    SmartCardAppletIdGroupActivationPolicy_ForegroundOverride = 1,

    /// <include file='SmartCardAppletIdGroupActivationPolicy.xml' path='doc/member[@name="SmartCardAppletIdGroupActivationPolicy.SmartCardAppletIdGroupActivationPolicy_Enabled"]/*' />
    SmartCardAppletIdGroupActivationPolicy_Enabled = 2,
}
