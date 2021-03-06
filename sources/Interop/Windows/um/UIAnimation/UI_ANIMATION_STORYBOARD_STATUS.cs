// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum UI_ANIMATION_STORYBOARD_STATUS
    {
        UI_ANIMATION_STORYBOARD_BUILDING = 0,
        UI_ANIMATION_STORYBOARD_SCHEDULED = 1,
        UI_ANIMATION_STORYBOARD_CANCELLED = 2,
        UI_ANIMATION_STORYBOARD_PLAYING = 3,
        UI_ANIMATION_STORYBOARD_TRUNCATED = 4,
        UI_ANIMATION_STORYBOARD_FINISHED = 5,
        UI_ANIMATION_STORYBOARD_READY = 6,
        UI_ANIMATION_STORYBOARD_INSUFFICIENT_PRIORITY = 7,
    }
}
