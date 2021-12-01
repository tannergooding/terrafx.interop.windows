// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1
{
    public BOOL Enable;

    public ID3D12Resource* pReferenceTexture2D;

    public uint ReferenceSubresource;

    public DXGI_COLOR_SPACE_TYPE OutputColorSpace;

    public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;

    public uint OutputWidth;

    public uint OutputHeight;
}