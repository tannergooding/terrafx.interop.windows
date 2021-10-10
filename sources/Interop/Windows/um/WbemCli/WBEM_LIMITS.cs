// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WBEM_LIMITS
    {
        WBEM_MAX_IDENTIFIER = 0x1000,
        WBEM_MAX_QUERY = 0x4000,
        WBEM_MAX_PATH = 0x2000,
        WBEM_MAX_OBJECT_NESTING = 64,
        WBEM_MAX_USER_PROPERTIES = 1024,
    }
}
