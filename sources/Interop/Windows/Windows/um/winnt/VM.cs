// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VM
{
    [NativeTypeName("#define VM_PREFETCH_TO_WORKING_SET 0x1")]
    public const int VM_PREFETCH_TO_WORKING_SET = 0x1;
}
