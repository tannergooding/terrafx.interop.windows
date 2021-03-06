// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TRANSLATION_PARAMETER
    {
        TRANSLATION_PARAMETER_MIN_CONTACT_COUNT = 0x00000000,
        TRANSLATION_PARAMETER_MAX_CONTACT_COUNT = 0x00000001,
        TRANSLATION_PARAMETER_MAX = unchecked((int)(0xffffffff)),
    }
}
