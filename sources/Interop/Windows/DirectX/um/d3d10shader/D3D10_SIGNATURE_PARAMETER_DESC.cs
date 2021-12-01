// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D10_SIGNATURE_PARAMETER_DESC
{
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    public uint SemanticIndex;

    public uint Register;

    [NativeTypeName("D3D10_NAME")]
    public D3D_NAME SystemValueType;

    [NativeTypeName("D3D10_REGISTER_COMPONENT_TYPE")]
    public D3D_REGISTER_COMPONENT_TYPE ComponentType;

    public byte Mask;

    public byte ReadWriteMask;
}