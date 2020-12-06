// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
    [NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
    public unsafe partial struct IDirect3DQuery9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[1]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[2]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new D3DQUERYTYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, D3DQUERYTYPE>)(lpVtbl[4]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint>)(lpVtbl[5]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Issue([NativeTypeName("DWORD")] uint dwIssueFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, uint, int>)(lpVtbl[6]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), dwIssueFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("void *")] void* pData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwGetDataFlags)
        {
            return ((delegate* unmanaged<IDirect3DQuery9*, void*, uint, uint, int>)(lpVtbl[7]))((IDirect3DQuery9*)Unsafe.AsPointer(ref this), pData, dwSize, dwGetDataFlags);
        }
    }
}
