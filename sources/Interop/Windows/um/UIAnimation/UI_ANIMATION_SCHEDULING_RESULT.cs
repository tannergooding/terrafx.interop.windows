// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum UI_ANIMATION_SCHEDULING_RESULT
    {
        UI_ANIMATION_SCHEDULING_UNEXPECTED_FAILURE = 0,
        UI_ANIMATION_SCHEDULING_INSUFFICIENT_PRIORITY = 1,
        UI_ANIMATION_SCHEDULING_ALREADY_SCHEDULED = 2,
        UI_ANIMATION_SCHEDULING_SUCCEEDED = 3,
        UI_ANIMATION_SCHEDULING_DEFERRED = 4,
    }
}
