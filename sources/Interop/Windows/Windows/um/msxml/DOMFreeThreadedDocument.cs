// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='DOMFreeThreadedDocument.xml' path='doc/member[@name="DOMFreeThreadedDocument"]/*' />
[Guid("2933BF91-7B36-11D2-B20E-00C04F983E60")]
public unsafe partial struct DOMFreeThreadedDocument : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_DOMFreeThreadedDocument));
}
