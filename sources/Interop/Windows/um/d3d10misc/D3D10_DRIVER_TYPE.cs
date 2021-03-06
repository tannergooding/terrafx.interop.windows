// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D10_DRIVER_TYPE
    {
        D3D10_DRIVER_TYPE_HARDWARE = 0,
        D3D10_DRIVER_TYPE_REFERENCE = 1,
        D3D10_DRIVER_TYPE_NULL = 2,
        D3D10_DRIVER_TYPE_SOFTWARE = 3,
        D3D10_DRIVER_TYPE_WARP = 5,
    }
}
