// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum SMINFOMASK
    {
        SMIM_TYPE = 0x1,
        SMIM_FLAGS = 0x2,
        SMIM_ICON = 0x4,
    }
}
