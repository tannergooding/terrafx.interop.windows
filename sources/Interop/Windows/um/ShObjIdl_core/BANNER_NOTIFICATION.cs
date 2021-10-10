// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct BANNER_NOTIFICATION
    {
        public BANNER_NOTIFICATION_EVENT @event;

        [NativeTypeName("LPCWSTR")]
        public ushort* providerIdentity;

        [NativeTypeName("LPCWSTR")]
        public ushort* contentId;
    }
}
