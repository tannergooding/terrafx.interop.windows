// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoSourceFilmContent.xml' path='doc/member[@name="CODECAPI_AVEncVideoSourceFilmContent"]/*' />
[Guid("1791C64B-CCFC-4827-A0ED-2557793B2B1C")]
public unsafe partial struct CODECAPI_AVEncVideoSourceFilmContent : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoSourceFilmContent));
}
