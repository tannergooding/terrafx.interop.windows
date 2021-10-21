// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SCOPE_LEVEL
    {
        ScopeLevelInterface = 1,
        ScopeLevelLink = 2,
        ScopeLevelSubnet = 3,
        ScopeLevelAdmin = 4,
        ScopeLevelSite = 5,
        ScopeLevelOrganization = 8,
        ScopeLevelGlobal = 14,
        ScopeLevelCount = 16,
    }
}