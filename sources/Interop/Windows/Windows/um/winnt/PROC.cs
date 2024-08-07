// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROC
{
    [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT 6")]
    public const int PROC_IDLE_BUCKET_COUNT = 6;

    [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT_EX 16")]
    public const int PROC_IDLE_BUCKET_COUNT_EX = 16;
}
