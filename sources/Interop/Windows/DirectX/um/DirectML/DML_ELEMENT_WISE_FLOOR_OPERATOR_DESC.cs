// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC
{
    /// <include file='DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_FLOOR_OPERATOR_DESC.ScaleBias"]/*' />
    [NativeTypeName("const DML_SCALE_BIAS *")]
    public DML_SCALE_BIAS* ScaleBias;
}
