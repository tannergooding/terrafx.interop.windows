// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.16299.0")]
    public enum READ_DIRECTORY_NOTIFY_INFORMATION_CLASS
    {
        ReadDirectoryNotifyInformation = 1,
        ReadDirectoryNotifyExtendedInformation,
    }
}
