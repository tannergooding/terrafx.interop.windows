// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFPOLICYMANAGER_ACTION
    {
        PEACTION_NO = 0,
        PEACTION_PLAY = 1,
        PEACTION_COPY = 2,
        PEACTION_EXPORT = 3,
        PEACTION_EXTRACT = 4,
        PEACTION_RESERVED1 = 5,
        PEACTION_RESERVED2 = 6,
        PEACTION_RESERVED3 = 7,
        PEACTION_LAST = 7,
    }
}
