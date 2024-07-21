// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncMPEG1Video.xml' path='doc/member[@name="CODECAPI_GUID_AVEncMPEG1Video"]/*' />
[Guid("C8DAFEFE-DA1E-4774-B27D-11830C16B1FE")]
public unsafe partial struct CODECAPI_GUID_AVEncMPEG1Video : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncMPEG1Video));
}
