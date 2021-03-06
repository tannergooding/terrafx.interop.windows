// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFMEDIASOURCE_CHARACTERISTICS
    {
        MFMEDIASOURCE_IS_LIVE = 0x1,
        MFMEDIASOURCE_CAN_SEEK = 0x2,
        MFMEDIASOURCE_CAN_PAUSE = 0x4,
        MFMEDIASOURCE_HAS_SLOW_SEEK = 0x8,
        MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS = 0x10,
        MFMEDIASOURCE_CAN_SKIPFORWARD = 0x20,
        MFMEDIASOURCE_CAN_SKIPBACKWARD = 0x40,
        MFMEDIASOURCE_DOES_NOT_USE_NETWORK = 0x80,
    }
}
