// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID"]/*' />
public enum WS_SERVICE_ENDPOINT_PROPERTY_ID
{
    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_ACCEPT_CHANNEL_CALLBACK"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_ACCEPT_CHANNEL_CALLBACK = 0,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_CLOSE_CHANNEL_CALLBACK"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_CLOSE_CHANNEL_CALLBACK = 1,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MAX_ACCEPTING_CHANNELS"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MAX_ACCEPTING_CHANNELS = 2,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MAX_CONCURRENCY"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MAX_CONCURRENCY = 3,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_BODY_HEAP_MAX_SIZE"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_BODY_HEAP_MAX_SIZE = 4,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_BODY_HEAP_TRIM_SIZE"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_BODY_HEAP_TRIM_SIZE = 5,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MESSAGE_PROPERTIES"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MESSAGE_PROPERTIES = 6,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MAX_CALL_POOL_SIZE"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MAX_CALL_POOL_SIZE = 7,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MAX_CHANNEL_POOL_SIZE"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MAX_CHANNEL_POOL_SIZE = 8,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_LISTENER_PROPERTIES"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_LISTENER_PROPERTIES = 9,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_CHECK_MUST_UNDERSTAND"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_CHECK_MUST_UNDERSTAND = 10,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_METADATA_EXCHANGE_TYPE"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_METADATA_EXCHANGE_TYPE = 11,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_METADATA"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_METADATA = 12,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_METADATA_EXCHANGE_URL_SUFFIX"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_METADATA_EXCHANGE_URL_SUFFIX = 13,

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY_ID.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY_ID.WS_SERVICE_ENDPOINT_PROPERTY_MAX_CHANNELS"]/*' />
    WS_SERVICE_ENDPOINT_PROPERTY_MAX_CHANNELS = 14,
}