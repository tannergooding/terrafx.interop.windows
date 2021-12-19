// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG"]/*' />
[Flags]
public enum D3D11_RESOURCE_MISC_FLAG
{
    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_GENERATE_MIPS"]/*' />
    D3D11_RESOURCE_MISC_GENERATE_MIPS = 0x1,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED"]/*' />
    D3D11_RESOURCE_MISC_SHARED = 0x2,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_TEXTURECUBE"]/*' />
    D3D11_RESOURCE_MISC_TEXTURECUBE = 0x4,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS"]/*' />
    D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS = 0x10,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS"]/*' />
    D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS = 0x20,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_BUFFER_STRUCTURED"]/*' />
    D3D11_RESOURCE_MISC_BUFFER_STRUCTURED = 0x40,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_RESOURCE_CLAMP"]/*' />
    D3D11_RESOURCE_MISC_RESOURCE_CLAMP = 0x80,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX"]/*' />
    D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX = 0x100,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_GDI_COMPATIBLE"]/*' />
    D3D11_RESOURCE_MISC_GDI_COMPATIBLE = 0x200,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED_NTHANDLE"]/*' />
    D3D11_RESOURCE_MISC_SHARED_NTHANDLE = 0x800,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_RESTRICTED_CONTENT"]/*' />
    D3D11_RESOURCE_MISC_RESTRICTED_CONTENT = 0x1000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE"]/*' />
    D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE = 0x2000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER"]/*' />
    D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER = 0x4000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_GUARDED"]/*' />
    D3D11_RESOURCE_MISC_GUARDED = 0x8000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_TILE_POOL"]/*' />
    D3D11_RESOURCE_MISC_TILE_POOL = 0x20000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_TILED"]/*' />
    D3D11_RESOURCE_MISC_TILED = 0x40000,

    /// <include file='D3D11_RESOURCE_MISC_FLAG.xml' path='doc/member[@name="D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_HW_PROTECTED"]/*' />
    D3D11_RESOURCE_MISC_HW_PROTECTED = 0x80000,
}
