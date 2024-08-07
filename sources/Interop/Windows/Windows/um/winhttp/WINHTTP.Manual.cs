// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class WINHTTP
{
    [NativeTypeName("#define WINHTTP_INVALID_STATUS_CALLBACK ((WINHTTP_STATUS_CALLBACK)(-1L))")]
    public static delegate* unmanaged<HINTERNET, nuint, uint, void*, uint, void> WINHTTP_INVALID_STATUS_CALLBACK => ((delegate* unmanaged<HINTERNET, nuint, uint, void*, uint, void>)(-1));
}
