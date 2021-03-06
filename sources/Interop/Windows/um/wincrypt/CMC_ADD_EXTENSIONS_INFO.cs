// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMC_ADD_EXTENSIONS_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwCmcDataReference;

        [NativeTypeName("DWORD")]
        public uint cCertReference;

        [NativeTypeName("DWORD *")]
        public uint* rgdwCertReference;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;
    }
}
