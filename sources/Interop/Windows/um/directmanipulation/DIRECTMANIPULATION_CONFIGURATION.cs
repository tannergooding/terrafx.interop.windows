// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DIRECTMANIPULATION_CONFIGURATION
    {
        DIRECTMANIPULATION_CONFIGURATION_NONE = 0,
        DIRECTMANIPULATION_CONFIGURATION_INTERACTION = 0x1,
        DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_X = 0x2,
        DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_Y = 0x4,
        DIRECTMANIPULATION_CONFIGURATION_SCALING = 0x10,
        DIRECTMANIPULATION_CONFIGURATION_TRANSLATION_INERTIA = 0x20,
        DIRECTMANIPULATION_CONFIGURATION_SCALING_INERTIA = 0x80,
        DIRECTMANIPULATION_CONFIGURATION_RAILS_X = 0x100,
        DIRECTMANIPULATION_CONFIGURATION_RAILS_Y = 0x200,
    }
}
