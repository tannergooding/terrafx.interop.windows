// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SVUIA_STATUS
    {
        SVUIA_DEACTIVATE = 0,
        SVUIA_ACTIVATE_NOFOCUS = 1,
        SVUIA_ACTIVATE_FOCUS = 2,
        SVUIA_INPLACEACTIVATE = 3,
    }
}