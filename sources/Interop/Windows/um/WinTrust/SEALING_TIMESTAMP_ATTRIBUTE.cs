// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SEALING_TIMESTAMP_ATTRIBUTE
    {
        [NativeTypeName("ULONG")]
        public uint version;

        [NativeTypeName("ULONG")]
        public uint signerIndex;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB sealTimeStampToken;
    }
}
