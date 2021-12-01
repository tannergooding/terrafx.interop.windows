// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

[Flags]
public enum D3D11_COPY_FLAGS
{
    D3D11_COPY_NO_OVERWRITE = 0x1,
    D3D11_COPY_DISCARD = 0x2,
}