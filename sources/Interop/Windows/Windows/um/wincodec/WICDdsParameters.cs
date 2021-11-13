// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    public partial struct WICDdsParameters
    {
        public uint Width;

        public uint Height;

        public uint Depth;

        public uint MipLevels;

        public uint ArraySize;

        public DXGI_FORMAT DxgiFormat;

        public WICDdsDimension Dimension;

        public WICDdsAlphaMode AlphaMode;
    }
}
