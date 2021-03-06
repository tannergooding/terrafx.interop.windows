// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum QACONTAINERFLAGS
    {
        QACONTAINER_SHOWHATCHING = 0x1,
        QACONTAINER_SHOWGRABHANDLES = 0x2,
        QACONTAINER_USERMODE = 0x4,
        QACONTAINER_DISPLAYASDEFAULT = 0x8,
        QACONTAINER_UIDEAD = 0x10,
        QACONTAINER_AUTOCLIP = 0x20,
        QACONTAINER_MESSAGEREFLECT = 0x40,
        QACONTAINER_SUPPORTSMNEMONICS = 0x80,
    }
}
