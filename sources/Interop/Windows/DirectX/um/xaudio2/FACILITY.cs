// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class FACILITY
{
    [NativeTypeName("#define FACILITY_XAUDIO2 0x896")]
    public const int FACILITY_XAUDIO2 = 0x896;
}
