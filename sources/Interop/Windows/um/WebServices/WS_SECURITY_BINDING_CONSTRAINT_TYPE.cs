// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_SECURITY_BINDING_CONSTRAINT_TYPE
    {
        WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE = 1,
        WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE = 2,
        WS_HTTP_HEADER_AUTH_SECURITY_BINDING_CONSTRAINT_TYPE = 3,
        WS_USERNAME_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 4,
        WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 5,
        WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 6,
        WS_CERT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 7,
        WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 8,
    }
}
