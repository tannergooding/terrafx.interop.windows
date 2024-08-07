// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='StorageProviderBanners.xml' path='doc/member[@name="StorageProviderBanners"]/*' />
[Guid("7CCDF9F4-E576-455A-8BC7-F6EC68D6F063")]
public unsafe partial struct StorageProviderBanners : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_StorageProviderBanners));
}
