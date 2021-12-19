// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS"]/*' />
public enum CASTING_CONNECTION_ERROR_STATUS
{
    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_SUCCEEDED"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_SUCCEEDED = 0,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_DEVICE_DID_NOT_RESPOND"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_DID_NOT_RESPOND = 1,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_DEVICE_ERROR"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_ERROR = 2,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_DEVICE_LOCKED"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_DEVICE_LOCKED = 3,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_PROTECTED_PLAYBACK_FAILED"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_PROTECTED_PLAYBACK_FAILED = 4,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_INVALID_CASTING_SOURCE"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_INVALID_CASTING_SOURCE = 5,

    /// <include file='CASTING_CONNECTION_ERROR_STATUS.xml' path='doc/member[@name="CASTING_CONNECTION_ERROR_STATUS.CASTING_CONNECTION_ERROR_STATUS_UNKNOWN"]/*' />
    CASTING_CONNECTION_ERROR_STATUS_UNKNOWN = 6,
}
