// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MsftStreamPrng001.xml' path='doc/member[@name="MsftStreamPrng001"]/*' />
[Guid("27354126-7F64-5B0F-8F00-5D77AFBE261E")]
public unsafe partial struct MsftStreamPrng001 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_MsftStreamPrng001));
}
