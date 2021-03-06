// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_ROI_ALIGN_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* ROITensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* BatchIndicesTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputTensor;

        public DML_REDUCE_FUNCTION ReductionFunction;

        public DML_INTERPOLATION_MODE InterpolationMode;

        [NativeTypeName("FLOAT")]
        public float SpatialScaleX;

        [NativeTypeName("FLOAT")]
        public float SpatialScaleY;

        [NativeTypeName("FLOAT")]
        public float OutOfBoundsInputValue;

        [NativeTypeName("UINT")]
        public uint MinimumSamplesPerOutput;

        [NativeTypeName("UINT")]
        public uint MaximumSamplesPerOutput;
    }
}
