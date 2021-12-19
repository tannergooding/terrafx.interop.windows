// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_INF_SIGNER_INFO32_V1_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort CatalogFile[260];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort DigitalSigner[260];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort DigitalSignerVersion[260];
}
