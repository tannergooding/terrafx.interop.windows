// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C9DD65E-D3F7-4529-ACEE-785830ACDE35")]
    [NativeTypeName("struct IDirect3DIndexBuffer9 : IDirect3DResource9")]
    public unsafe partial struct IDirect3DIndexBuffer9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[1]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[2]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("void *")] void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, Guid*, int>)(lpVtbl[6]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), refguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint, uint>)(lpVtbl[7]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint>)(lpVtbl[8]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DIndexBuffer9*, void>)(lpVtbl[9]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new D3DRESOURCETYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("UINT")] uint OffsetToLock, [NativeTypeName("UINT")] uint SizeToLock, [NativeTypeName("void **")] void** ppbData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)(lpVtbl[11]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), OffsetToLock, SizeToLock, ppbData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, int>)(lpVtbl[12]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3DINDEXBUFFER_DESC *")] D3DINDEXBUFFER_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DIndexBuffer9*, D3DINDEXBUFFER_DESC*, int>)(lpVtbl[13]))((IDirect3DIndexBuffer9*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
