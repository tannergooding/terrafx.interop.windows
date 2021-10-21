// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE
    {
        CPGSR_NO_CREDENTIAL_NOT_FINISHED = 0,
        CPGSR_NO_CREDENTIAL_FINISHED = (CPGSR_NO_CREDENTIAL_NOT_FINISHED + 1),
        CPGSR_RETURN_CREDENTIAL_FINISHED = (CPGSR_NO_CREDENTIAL_FINISHED + 1),
        CPGSR_RETURN_NO_CREDENTIAL_FINISHED = (CPGSR_RETURN_CREDENTIAL_FINISHED + 1),
    }
}