// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CRYPT_REGISTER_ACTIONID
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        public CRYPT_TRUST_REG_ENTRY sInitProvider;

        public CRYPT_TRUST_REG_ENTRY sObjectProvider;

        public CRYPT_TRUST_REG_ENTRY sSignatureProvider;

        public CRYPT_TRUST_REG_ENTRY sCertificateProvider;

        public CRYPT_TRUST_REG_ENTRY sCertificatePolicyProvider;

        public CRYPT_TRUST_REG_ENTRY sFinalPolicyProvider;

        public CRYPT_TRUST_REG_ENTRY sTestPolicyProvider;

        public CRYPT_TRUST_REG_ENTRY sCleanupProvider;
    }
}
