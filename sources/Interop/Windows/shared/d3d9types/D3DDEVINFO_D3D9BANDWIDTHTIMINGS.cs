// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3DDEVINFO_D3D9BANDWIDTHTIMINGS
    {
        [NativeTypeName("FLOAT")]
        public float MaxBandwidthUtilized;

        [NativeTypeName("FLOAT")]
        public float FrontEndUploadMemoryUtilizedPercent;

        [NativeTypeName("FLOAT")]
        public float VertexRateUtilizedPercent;

        [NativeTypeName("FLOAT")]
        public float TriangleSetupRateUtilizedPercent;

        [NativeTypeName("FLOAT")]
        public float FillRateUtilizedPercent;
    }
}
