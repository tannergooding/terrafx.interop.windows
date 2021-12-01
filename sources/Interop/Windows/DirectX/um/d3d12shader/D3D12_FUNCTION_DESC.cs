// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_FUNCTION_DESC
{
    public uint Version;

    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;

    public uint Flags;

    public uint ConstantBuffers;

    public uint BoundResources;

    public uint InstructionCount;

    public uint TempRegisterCount;

    public uint TempArrayCount;

    public uint DefCount;

    public uint DclCount;

    public uint TextureNormalInstructions;

    public uint TextureLoadInstructions;

    public uint TextureCompInstructions;

    public uint TextureBiasInstructions;

    public uint TextureGradientInstructions;

    public uint FloatInstructionCount;

    public uint IntInstructionCount;

    public uint UintInstructionCount;

    public uint StaticFlowControlCount;

    public uint DynamicFlowControlCount;

    public uint MacroInstructionCount;

    public uint ArrayInstructionCount;

    public uint MovInstructionCount;

    public uint MovcInstructionCount;

    public uint ConversionInstructionCount;

    public uint BitwiseInstructionCount;

    public D3D_FEATURE_LEVEL MinFeatureLevel;

    [NativeTypeName("UINT64")]
    public ulong RequiredFeatureFlags;

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    public int FunctionParameterCount;

    public BOOL HasReturn;

    public BOOL Has10Level9VertexShader;

    public BOOL Has10Level9PixelShader;
}