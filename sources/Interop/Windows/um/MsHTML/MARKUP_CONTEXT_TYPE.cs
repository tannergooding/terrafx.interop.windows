// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MARKUP_CONTEXT_TYPE
    {
        CONTEXT_TYPE_None = 0,
        CONTEXT_TYPE_Text = 1,
        CONTEXT_TYPE_EnterScope = 2,
        CONTEXT_TYPE_ExitScope = 3,
        CONTEXT_TYPE_NoScope = 4,
        MARKUP_CONTEXT_TYPE_Max = 2147483647,
    }
}