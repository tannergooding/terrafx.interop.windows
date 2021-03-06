// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_CONTENT_PROTECTION_CAPS
    {
        D3D11_CONTENT_PROTECTION_CAPS_SOFTWARE = 0x1,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE = 0x2,
        D3D11_CONTENT_PROTECTION_CAPS_PROTECTION_ALWAYS_ON = 0x4,
        D3D11_CONTENT_PROTECTION_CAPS_PARTIAL_DECRYPTION = 0x8,
        D3D11_CONTENT_PROTECTION_CAPS_CONTENT_KEY = 0x10,
        D3D11_CONTENT_PROTECTION_CAPS_FRESHEN_SESSION_KEY = 0x20,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK = 0x40,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPTED_READ_BACK_KEY = 0x80,
        D3D11_CONTENT_PROTECTION_CAPS_SEQUENTIAL_CTR_IV = 0x100,
        D3D11_CONTENT_PROTECTION_CAPS_ENCRYPT_SLICEDATA_ONLY = 0x200,
        D3D11_CONTENT_PROTECTION_CAPS_DECRYPTION_BLT = 0x400,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECT_UNCOMPRESSED = 0x800,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_PROTECTED_MEMORY_PAGEABLE = 0x1000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_TEARDOWN = 0x2000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION = 0x4000,
        D3D11_CONTENT_PROTECTION_CAPS_HARDWARE_DRM_COMMUNICATION_MULTI_THREADED = 0x8000,
    }
}
