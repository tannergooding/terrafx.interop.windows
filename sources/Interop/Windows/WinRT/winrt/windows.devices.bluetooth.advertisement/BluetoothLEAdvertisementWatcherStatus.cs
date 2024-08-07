// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus"]/*' />
public enum BluetoothLEAdvertisementWatcherStatus
{
    /// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus.BluetoothLEAdvertisementWatcherStatus_Created"]/*' />
    BluetoothLEAdvertisementWatcherStatus_Created = 0,

    /// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus.BluetoothLEAdvertisementWatcherStatus_Started"]/*' />
    BluetoothLEAdvertisementWatcherStatus_Started = 1,

    /// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus.BluetoothLEAdvertisementWatcherStatus_Stopping"]/*' />
    BluetoothLEAdvertisementWatcherStatus_Stopping = 2,

    /// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus.BluetoothLEAdvertisementWatcherStatus_Stopped"]/*' />
    BluetoothLEAdvertisementWatcherStatus_Stopped = 3,

    /// <include file='BluetoothLEAdvertisementWatcherStatus.xml' path='doc/member[@name="BluetoothLEAdvertisementWatcherStatus.BluetoothLEAdvertisementWatcherStatus_Aborted"]/*' />
    BluetoothLEAdvertisementWatcherStatus_Aborted = 4,
}
