// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TIMED_TEXT_TRACK_READY_STATE
    {
        MF_TIMED_TEXT_TRACK_READY_STATE_NONE = 0,
        MF_TIMED_TEXT_TRACK_READY_STATE_LOADING = (MF_TIMED_TEXT_TRACK_READY_STATE_NONE + 1),
        MF_TIMED_TEXT_TRACK_READY_STATE_LOADED = (MF_TIMED_TEXT_TRACK_READY_STATE_LOADING + 1),
        MF_TIMED_TEXT_TRACK_READY_STATE_ERROR = (MF_TIMED_TEXT_TRACK_READY_STATE_LOADED + 1),
    }
}
