// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_ALT_NAME_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cAltEntry;

        [NativeTypeName("PCERT_ALT_NAME_ENTRY")]
        public CERT_ALT_NAME_ENTRY* rgAltEntry;
    }
}
