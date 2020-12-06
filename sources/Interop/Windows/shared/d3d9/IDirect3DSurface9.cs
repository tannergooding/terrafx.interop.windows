// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0CFBAF3A-9FF6-429A-99B3-A2796AF8B89B")]
    [NativeTypeName("struct IDirect3DSurface9 : IDirect3DResource9")]
    public unsafe partial struct IDirect3DSurface9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, uint>)(lpVtbl[1]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, uint>)(lpVtbl[2]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("void *")] void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, Guid*, int>)(lpVtbl[6]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), refguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, uint, uint>)(lpVtbl[7]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, uint>)(lpVtbl[8]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DSurface9*, void>)(lpVtbl[9]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new D3DRESOURCETYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppContainer)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, Guid*, void**, int>)(lpVtbl[11]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), riid, ppContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3DSURFACE_DESC *")] D3DSURFACE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, D3DSURFACE_DESC*, int>)(lpVtbl[12]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRect([NativeTypeName("D3DLOCKED_RECT *")] D3DLOCKED_RECT* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, D3DLOCKED_RECT*, RECT*, uint, int>)(lpVtbl[13]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), pLockedRect, pRect, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRect()
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, int>)(lpVtbl[14]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* phdc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, IntPtr*, int>)(lpVtbl[15]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), phdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr hdc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9*, IntPtr, int>)(lpVtbl[16]))((IDirect3DSurface9*)Unsafe.AsPointer(ref this), hdc);
        }
    }
}
