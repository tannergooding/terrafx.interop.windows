// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_INPUT_LAYOUT_DESC pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT([NativeTypeName("D3D12_INPUT_LAYOUT_DESC const &")] in D3D12_INPUT_LAYOUT_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT(in D3D12_INPUT_LAYOUT_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT(value);

    public static implicit operator D3D12_INPUT_LAYOUT_DESC(in CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT value) => value.pssInner;
}
