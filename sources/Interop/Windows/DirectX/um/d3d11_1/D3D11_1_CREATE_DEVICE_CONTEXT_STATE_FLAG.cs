// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

[Flags]
public enum D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG
{
    D3D11_1_CREATE_DEVICE_CONTEXT_STATE_SINGLETHREADED = 0x1,
}