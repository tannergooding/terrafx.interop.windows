// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID"]/*' />
public enum WS_SECURITY_BINDING_PROPERTY_ID
{
    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_REQUIRE_SSL_CLIENT_CERT"]/*' />
    WS_SECURITY_BINDING_PROPERTY_REQUIRE_SSL_CLIENT_CERT = 1,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_WINDOWS_INTEGRATED_AUTH_PACKAGE"]/*' />
    WS_SECURITY_BINDING_PROPERTY_WINDOWS_INTEGRATED_AUTH_PACKAGE = 2,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_REQUIRE_SERVER_AUTH"]/*' />
    WS_SECURITY_BINDING_PROPERTY_REQUIRE_SERVER_AUTH = 3,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_ALLOW_ANONYMOUS_CLIENTS"]/*' />
    WS_SECURITY_BINDING_PROPERTY_ALLOW_ANONYMOUS_CLIENTS = 4,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_ALLOWED_IMPERSONATION_LEVEL"]/*' />
    WS_SECURITY_BINDING_PROPERTY_ALLOWED_IMPERSONATION_LEVEL = 5,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_SCHEME"]/*' />
    WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_SCHEME = 6,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_TARGET"]/*' />
    WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_TARGET = 7,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_BASIC_REALM"]/*' />
    WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_BASIC_REALM = 8,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_DIGEST_REALM"]/*' />
    WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_DIGEST_REALM = 9,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_DIGEST_DOMAIN"]/*' />
    WS_SECURITY_BINDING_PROPERTY_HTTP_HEADER_AUTH_DIGEST_DOMAIN = 10,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_KEY_SIZE"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_KEY_SIZE = 11,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_KEY_ENTROPY_MODE"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_KEY_ENTROPY_MODE = 12,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_MESSAGE_PROPERTIES"]/*' />
    WS_SECURITY_BINDING_PROPERTY_MESSAGE_PROPERTIES = 13,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_MAX_PENDING_CONTEXTS"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_MAX_PENDING_CONTEXTS = 14,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_MAX_ACTIVE_CONTEXTS"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_MAX_ACTIVE_CONTEXTS = 15,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURE_CONVERSATION_VERSION"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURE_CONVERSATION_VERSION = 16,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_SUPPORT_RENEW"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_SUPPORT_RENEW = 17,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_RENEWAL_INTERVAL"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_RENEWAL_INTERVAL = 18,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_ROLLOVER_INTERVAL"]/*' />
    WS_SECURITY_BINDING_PROPERTY_SECURITY_CONTEXT_ROLLOVER_INTERVAL = 19,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_CERT_FAILURES_TO_IGNORE"]/*' />
    WS_SECURITY_BINDING_PROPERTY_CERT_FAILURES_TO_IGNORE = 20,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_DISABLE_CERT_REVOCATION_CHECK"]/*' />
    WS_SECURITY_BINDING_PROPERTY_DISABLE_CERT_REVOCATION_CHECK = 21,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_DISALLOWED_SECURE_PROTOCOLS"]/*' />
    WS_SECURITY_BINDING_PROPERTY_DISALLOWED_SECURE_PROTOCOLS = 22,

    /// <include file='WS_SECURITY_BINDING_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_ID.WS_SECURITY_BINDING_PROPERTY_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT"]/*' />
    WS_SECURITY_BINDING_PROPERTY_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT = 23,
}
