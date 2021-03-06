// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum UASFLAGS
    {
        UAS_NORMAL = 0,
        UAS_BLOCKED = 0x1,
        UAS_NOPARENTENABLE = 0x2,
        UAS_MASK = 0x3,
    }
}
