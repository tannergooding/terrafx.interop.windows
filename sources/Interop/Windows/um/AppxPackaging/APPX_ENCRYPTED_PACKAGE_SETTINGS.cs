// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct APPX_ENCRYPTED_PACKAGE_SETTINGS
    {
        [NativeTypeName("UINT32")]
        public uint keyLength;

        [NativeTypeName("LPCWSTR")]
        public ushort* encryptionAlgorithm;

        public BOOL useDiffusion;

        public IUri* blockMapHashAlgorithm;
    }
}
