// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPTOAPI_BLOB SerialNumber;

        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPTOAPI_BLOB Issuer;

        public FILETIME NotBefore;

        public FILETIME NotAfter;

        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPTOAPI_BLOB Subject;

        public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

        public CRYPT_BIT_BLOB IssuerUniqueId;

        public CRYPT_BIT_BLOB SubjectUniqueId;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;
    }
}
