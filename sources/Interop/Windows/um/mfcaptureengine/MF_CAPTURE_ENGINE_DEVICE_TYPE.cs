// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public enum MF_CAPTURE_ENGINE_DEVICE_TYPE
    {
        MF_CAPTURE_ENGINE_DEVICE_TYPE_AUDIO = 0,
        MF_CAPTURE_ENGINE_DEVICE_TYPE_VIDEO = 0x1,
    }
}
