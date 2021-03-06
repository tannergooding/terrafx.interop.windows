// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum BINDF2
    {
        BINDF2_DISABLEBASICOVERHTTP = 0x1,
        BINDF2_DISABLEAUTOCOOKIEHANDLING = 0x2,
        BINDF2_READ_DATA_GREATER_THAN_4GB = 0x4,
        BINDF2_DISABLE_HTTP_REDIRECT_XSECURITYID = 0x8,
        BINDF2_SETDOWNLOADMODE = 0x20,
        BINDF2_DISABLE_HTTP_REDIRECT_CACHING = 0x40,
        BINDF2_KEEP_CALLBACK_MODULE_LOADED = 0x80,
        BINDF2_ALLOW_PROXY_CRED_PROMPT = 0x100,
        BINDF2_RESERVED_17 = 0x200,
        BINDF2_RESERVED_16 = 0x400,
        BINDF2_RESERVED_15 = 0x800,
        BINDF2_RESERVED_14 = 0x1000,
        BINDF2_RESERVED_13 = 0x2000,
        BINDF2_RESERVED_12 = 0x4000,
        BINDF2_RESERVED_11 = 0x8000,
        BINDF2_RESERVED_10 = 0x10000,
        BINDF2_RESERVED_F = 0x20000,
        BINDF2_RESERVED_E = 0x40000,
        BINDF2_RESERVED_D = 0x80000,
        BINDF2_RESERVED_C = 0x100000,
        BINDF2_RESERVED_B = 0x200000,
        BINDF2_RESERVED_A = 0x400000,
        BINDF2_RESERVED_9 = 0x800000,
        BINDF2_RESERVED_8 = 0x1000000,
        BINDF2_RESERVED_7 = 0x2000000,
        BINDF2_RESERVED_6 = 0x4000000,
        BINDF2_RESERVED_5 = 0x8000000,
        BINDF2_RESERVED_4 = 0x10000000,
        BINDF2_RESERVED_3 = 0x20000000,
        BINDF2_RESERVED_2 = 0x40000000,
        BINDF2_RESERVED_1 = unchecked((int)(0x80000000)),
    }
}
