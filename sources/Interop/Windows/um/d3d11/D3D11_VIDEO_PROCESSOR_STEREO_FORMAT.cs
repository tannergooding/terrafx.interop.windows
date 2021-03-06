// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D11_VIDEO_PROCESSOR_STEREO_FORMAT
    {
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO = 0,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL = 1,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL = 2,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE = 3,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET = 4,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED = 5,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED = 6,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD = 7,
    }
}
