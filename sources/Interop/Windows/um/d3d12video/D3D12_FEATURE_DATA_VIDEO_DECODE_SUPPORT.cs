// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        public DXGI_FORMAT DecodeFormat;

        public DXGI_RATIONAL FrameRate;

        [NativeTypeName("UINT")]
        public uint BitRate;

        public D3D12_VIDEO_DECODE_SUPPORT_FLAGS SupportFlags;

        public D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS ConfigurationFlags;

        public D3D12_VIDEO_DECODE_TIER DecodeTier;
    }
}
