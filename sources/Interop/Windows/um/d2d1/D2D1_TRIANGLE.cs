// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_TRIANGLE
    {
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point1;

        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point2;

        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point3;
    }
}
