// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_ENDPOINT_IDENTITY_TYPE
    {
        WS_DNS_ENDPOINT_IDENTITY_TYPE = 1,
        WS_UPN_ENDPOINT_IDENTITY_TYPE = 2,
        WS_SPN_ENDPOINT_IDENTITY_TYPE = 3,
        WS_RSA_ENDPOINT_IDENTITY_TYPE = 4,
        WS_CERT_ENDPOINT_IDENTITY_TYPE = 5,
        WS_UNKNOWN_ENDPOINT_IDENTITY_TYPE = 6,
    }
}
