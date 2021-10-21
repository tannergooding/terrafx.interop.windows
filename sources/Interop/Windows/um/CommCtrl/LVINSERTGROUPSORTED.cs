// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVINSERTGROUPSORTED
    {
        [NativeTypeName("PFNLVGROUPCOMPARE")]
        public delegate* unmanaged<int, int, void*, int> pfnGroupCompare;

        public void* pvData;

        public LVGROUP lvGroup;
    }
}