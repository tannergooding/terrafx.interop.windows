// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagBIND_OPTS3 : tagBIND_OPTS2")]
    public partial struct BIND_OPTS3
    {
        public BIND_OPTS2 __AnonymousBase_objidl_L9008_C36;

        [NativeTypeName("HWND")]
        public IntPtr hwnd;
    }
}
