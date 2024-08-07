// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AppxEncryptionFactory.xml' path='doc/member[@name="AppxEncryptionFactory"]/*' />
[Guid("DC664FDD-D868-46EE-8780-8D196CB739F7")]
public unsafe partial struct AppxEncryptionFactory : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AppxEncryptionFactory));
}
