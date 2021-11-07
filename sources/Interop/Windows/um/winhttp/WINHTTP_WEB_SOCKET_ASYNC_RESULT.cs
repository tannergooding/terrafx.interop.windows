// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct WINHTTP_WEB_SOCKET_ASYNC_RESULT
    {
        public WINHTTP_ASYNC_RESULT AsyncResult;

        public WINHTTP_WEB_SOCKET_OPERATION Operation;
    }
}
