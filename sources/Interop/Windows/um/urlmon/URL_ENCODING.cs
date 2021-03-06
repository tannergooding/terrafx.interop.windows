// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum URL_ENCODING
    {
        URL_ENCODING_NONE = 0,
        URL_ENCODING_ENABLE_UTF8 = 0x10000000,
        URL_ENCODING_DISABLE_UTF8 = 0x20000000,
    }
}
