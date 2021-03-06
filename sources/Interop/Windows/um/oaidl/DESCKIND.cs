// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DESCKIND
    {
        DESCKIND_NONE = 0,
        DESCKIND_FUNCDESC = (DESCKIND_NONE + 1),
        DESCKIND_VARDESC = (DESCKIND_FUNCDESC + 1),
        DESCKIND_TYPECOMP = (DESCKIND_VARDESC + 1),
        DESCKIND_IMPLICITAPPOBJ = (DESCKIND_TYPECOMP + 1),
        DESCKIND_MAX = (DESCKIND_IMPLICITAPPOBJ + 1),
    }
}
