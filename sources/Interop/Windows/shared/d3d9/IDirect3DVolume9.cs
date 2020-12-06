// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24F416E6-1F67-4AA7-B88E-D33F6F3128A1")]
    [NativeTypeName("struct IDirect3DVolume9 : IUnknown")]
    public unsafe partial struct IDirect3DVolume9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, uint>)(lpVtbl[1]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, uint>)(lpVtbl[2]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("void *")] void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, int>)(lpVtbl[6]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), refguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppContainer)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)(lpVtbl[7]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), riid, ppContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3DVOLUME_DESC *")] D3DVOLUME_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, D3DVOLUME_DESC*, int>)(lpVtbl[8]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockBox([NativeTypeName("D3DLOCKED_BOX *")] D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, D3DLOCKED_BOX*, D3DBOX*, uint, int>)(lpVtbl[9]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this), pLockedVolume, pBox, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockBox()
        {
            return ((delegate* unmanaged<IDirect3DVolume9*, int>)(lpVtbl[10]))((IDirect3DVolume9*)Unsafe.AsPointer(ref this));
        }
    }
}
