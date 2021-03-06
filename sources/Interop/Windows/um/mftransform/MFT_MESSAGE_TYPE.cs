// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFT_MESSAGE_TYPE
    {
        MFT_MESSAGE_COMMAND_FLUSH = 0,
        MFT_MESSAGE_COMMAND_DRAIN = 0x1,
        MFT_MESSAGE_SET_D3D_MANAGER = 0x2,
        MFT_MESSAGE_DROP_SAMPLES = 0x3,
        MFT_MESSAGE_COMMAND_TICK = 0x4,
        MFT_MESSAGE_NOTIFY_BEGIN_STREAMING = 0x10000000,
        MFT_MESSAGE_NOTIFY_END_STREAMING = 0x10000001,
        MFT_MESSAGE_NOTIFY_END_OF_STREAM = 0x10000002,
        MFT_MESSAGE_NOTIFY_START_OF_STREAM = 0x10000003,
        MFT_MESSAGE_NOTIFY_RELEASE_RESOURCES = 0x10000004,
        MFT_MESSAGE_NOTIFY_REACQUIRE_RESOURCES = 0x10000005,
        MFT_MESSAGE_NOTIFY_EVENT = 0x10000006,
        MFT_MESSAGE_COMMAND_SET_OUTPUT_STREAM_STATE = 0x10000007,
        MFT_MESSAGE_COMMAND_FLUSH_OUTPUT_STREAM = 0x10000008,
        MFT_MESSAGE_COMMAND_MARKER = 0x20000000,
    }
}
