// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardEmulatorConnectionSource.xml' path='doc/member[@name="SmartCardEmulatorConnectionSource"]/*' />
public enum SmartCardEmulatorConnectionSource
{
    /// <include file='SmartCardEmulatorConnectionSource.xml' path='doc/member[@name="SmartCardEmulatorConnectionSource.SmartCardEmulatorConnectionSource_Unknown"]/*' />
    SmartCardEmulatorConnectionSource_Unknown = 0,

    /// <include file='SmartCardEmulatorConnectionSource.xml' path='doc/member[@name="SmartCardEmulatorConnectionSource.SmartCardEmulatorConnectionSource_NfcReader"]/*' />
    SmartCardEmulatorConnectionSource_NfcReader = 1,
}
