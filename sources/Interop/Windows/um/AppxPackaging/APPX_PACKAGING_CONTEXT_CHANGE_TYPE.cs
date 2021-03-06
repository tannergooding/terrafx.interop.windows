// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum APPX_PACKAGING_CONTEXT_CHANGE_TYPE
    {
        APPX_PACKAGING_CONTEXT_CHANGE_TYPE_START = 0,
        APPX_PACKAGING_CONTEXT_CHANGE_TYPE_CHANGE = 1,
        APPX_PACKAGING_CONTEXT_CHANGE_TYPE_DETAILS = 2,
        APPX_PACKAGING_CONTEXT_CHANGE_TYPE_END = 3,
    }
}
