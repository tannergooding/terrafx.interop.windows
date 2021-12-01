// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_POWERMESSAGEWAKE_PARAMS32_A
{
    public SP_CLASSINSTALL_HEADER32 ClassInstallHeader;

    [NativeTypeName("CHAR [512]")]
    public fixed sbyte PowerMessageWake[512];
}