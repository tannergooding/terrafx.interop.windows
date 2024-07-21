// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VibrationAccessStatus.xml' path='doc/member[@name="VibrationAccessStatus"]/*' />
public enum VibrationAccessStatus
{
    /// <include file='VibrationAccessStatus.xml' path='doc/member[@name="VibrationAccessStatus.VibrationAccessStatus_Allowed"]/*' />
    VibrationAccessStatus_Allowed = 0,

    /// <include file='VibrationAccessStatus.xml' path='doc/member[@name="VibrationAccessStatus.VibrationAccessStatus_DeniedByUser"]/*' />
    VibrationAccessStatus_DeniedByUser = 1,

    /// <include file='VibrationAccessStatus.xml' path='doc/member[@name="VibrationAccessStatus.VibrationAccessStatus_DeniedBySystem"]/*' />
    VibrationAccessStatus_DeniedBySystem = 2,

    /// <include file='VibrationAccessStatus.xml' path='doc/member[@name="VibrationAccessStatus.VibrationAccessStatus_DeniedByEnergySaver"]/*' />
    VibrationAccessStatus_DeniedByEnergySaver = 3,
}
