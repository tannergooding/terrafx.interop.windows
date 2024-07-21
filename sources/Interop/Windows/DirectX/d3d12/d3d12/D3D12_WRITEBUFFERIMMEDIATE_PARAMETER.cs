// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WRITEBUFFERIMMEDIATE_PARAMETER.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER"]/*' />
public partial struct D3D12_WRITEBUFFERIMMEDIATE_PARAMETER
{
    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_PARAMETER.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER.Dest"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong Dest;

    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_PARAMETER.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER.Value"]/*' />
    [NativeTypeName("UINT32")]
    public uint Value;
}
