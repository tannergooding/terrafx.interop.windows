// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum WICComponentType
    {
        WICDecoder = 0x1,

        WICEncoder = 0x2,

        WICPixelFormatConverter = 0x4,

        WICMetadataReader = 0x8,

        WICMetadataWriter = 0x10,

        WICPixelFormat = 0x20,

        WICAllComponents = 0x3F,

        WICCOMPONENTTYPE_FORCE_DWORD = 0x7FFFFFFF
    }
}