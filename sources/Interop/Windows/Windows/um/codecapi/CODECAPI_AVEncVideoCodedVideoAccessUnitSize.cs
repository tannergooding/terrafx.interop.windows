// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoCodedVideoAccessUnitSize.xml' path='doc/member[@name="CODECAPI_AVEncVideoCodedVideoAccessUnitSize"]/*' />
[Guid("B4B10C15-14A7-4CE8-B173-DC90A0B4FCDB")]
public unsafe partial struct CODECAPI_AVEncVideoCodedVideoAccessUnitSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoCodedVideoAccessUnitSize));
}
