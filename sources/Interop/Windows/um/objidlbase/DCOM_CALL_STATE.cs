// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DCOM_CALL_STATE
    {
        DCOM_NONE = 0,
        DCOM_CALL_COMPLETE = 0x1,
        DCOM_CALL_CANCELED = 0x2,
    }
}