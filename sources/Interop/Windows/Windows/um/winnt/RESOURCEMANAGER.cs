// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RESOURCEMANAGER
{
    [NativeTypeName("#define RESOURCEMANAGER_QUERY_INFORMATION ( 0x0001 )")]
    public const int RESOURCEMANAGER_QUERY_INFORMATION = (0x0001);

    [NativeTypeName("#define RESOURCEMANAGER_SET_INFORMATION ( 0x0002 )")]
    public const int RESOURCEMANAGER_SET_INFORMATION = (0x0002);

    [NativeTypeName("#define RESOURCEMANAGER_RECOVER ( 0x0004 )")]
    public const int RESOURCEMANAGER_RECOVER = (0x0004);

    [NativeTypeName("#define RESOURCEMANAGER_ENLIST ( 0x0008 )")]
    public const int RESOURCEMANAGER_ENLIST = (0x0008);

    [NativeTypeName("#define RESOURCEMANAGER_GET_NOTIFICATION ( 0x0010 )")]
    public const int RESOURCEMANAGER_GET_NOTIFICATION = (0x0010);

    [NativeTypeName("#define RESOURCEMANAGER_REGISTER_PROTOCOL ( 0x0020 )")]
    public const int RESOURCEMANAGER_REGISTER_PROTOCOL = (0x0020);

    [NativeTypeName("#define RESOURCEMANAGER_COMPLETE_PROPAGATION ( 0x0040 )")]
    public const int RESOURCEMANAGER_COMPLETE_PROPAGATION = (0x0040);

    [NativeTypeName("#define RESOURCEMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ                 |\\\r\n                                             RESOURCEMANAGER_QUERY_INFORMATION    |\\\r\n                                             SYNCHRONIZE)")]
    public const int RESOURCEMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x00100000));

    [NativeTypeName("#define RESOURCEMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE                |\\\r\n                                             RESOURCEMANAGER_SET_INFORMATION      |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_REGISTER_PROTOCOL    |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
    public const int RESOURCEMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000));

    [NativeTypeName("#define RESOURCEMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE              |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
    public const int RESOURCEMANAGER_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000));

    [NativeTypeName("#define RESOURCEMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED             |\\\r\n                                             RESOURCEMANAGER_GENERIC_READ         |\\\r\n                                             RESOURCEMANAGER_GENERIC_WRITE        |\\\r\n                                             RESOURCEMANAGER_GENERIC_EXECUTE)")]
    public const int RESOURCEMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001) | (0x00100000)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000)));
}
