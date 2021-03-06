// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum UI_ANIMATION_DEPENDENCIES
    {
        UI_ANIMATION_DEPENDENCY_NONE = 0,
        UI_ANIMATION_DEPENDENCY_INTERMEDIATE_VALUES = 0x1,
        UI_ANIMATION_DEPENDENCY_FINAL_VALUE = 0x2,
        UI_ANIMATION_DEPENDENCY_FINAL_VELOCITY = 0x4,
        UI_ANIMATION_DEPENDENCY_DURATION = 0x8,
    }
}
