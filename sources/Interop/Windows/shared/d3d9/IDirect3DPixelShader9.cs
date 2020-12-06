// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D3BDBDC-5B02-4415-B852-CE5E8BCCB289")]
    [NativeTypeName("struct IDirect3DPixelShader9 : IUnknown")]
    public unsafe partial struct IDirect3DPixelShader9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9*, uint>)(lpVtbl[1]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9*, uint>)(lpVtbl[2]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFunction([NativeTypeName("void *")] void* param0, [NativeTypeName("UINT *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DPixelShader9*, void*, uint*, int>)(lpVtbl[4]))((IDirect3DPixelShader9*)Unsafe.AsPointer(ref this), param0, pSizeOfData);
        }
    }
}
