// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct PACKAGE_INFO
{
    [NativeTypeName("UINT32")]
    public uint reserved;

    [NativeTypeName("UINT32")]
    public uint flags;

    [NativeTypeName("PWSTR")]
    public char* path;

    [NativeTypeName("PWSTR")]
    public char* packageFullName;

    [NativeTypeName("PWSTR")]
    public char* packageFamilyName;

    public PACKAGE_ID packageId;
}
