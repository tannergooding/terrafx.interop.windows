// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_TRACE_STEP
{
    public uint ID;

    public BOOL InstructionActive;

    [NativeTypeName("UINT8")]
    public byte NumRegistersWritten;

    [NativeTypeName("UINT8")]
    public byte NumRegistersRead;

    [NativeTypeName("D3D11_TRACE_MISC_OPERATIONS_MASK")]
    public ushort MiscOperations;

    public uint OpcodeType;

    [NativeTypeName("UINT64")]
    public ulong CurrentGlobalCycle;
}