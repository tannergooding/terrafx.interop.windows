// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEnableInLoopDeblockFilter.xml' path='doc/member[@name="CODECAPI_AVEnableInLoopDeblockFilter"]/*' />
[Guid("D2E8E399-0623-4BF3-92A8-4D1818529DED")]
public unsafe partial struct CODECAPI_AVEnableInLoopDeblockFilter : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEnableInLoopDeblockFilter));
}
