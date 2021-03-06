// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPDATAKEYLOCATION;

namespace TerraFX.Interop
{
    public enum SpeechDataKeyLocation
    {
        SDKLDefaultLocation = SPDKL_DefaultLocation,
        SDKLCurrentUser = SPDKL_CurrentUser,
        SDKLLocalMachine = SPDKL_LocalMachine,
        SDKLCurrentConfig = SPDKL_CurrentConfig,
    }
}
