// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NET
{
    [NativeTypeName("#define NET_IF_CURRENT_SESSION ((ULONG)-1)")]
    public const uint NET_IF_CURRENT_SESSION = unchecked((uint)(-1));
}
