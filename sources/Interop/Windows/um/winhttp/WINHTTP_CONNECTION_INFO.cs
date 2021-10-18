// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct WINHTTP_CONNECTION_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public SOCKADDR_STORAGE LocalAddress;

        public SOCKADDR_STORAGE RemoteAddress;
    }
}
