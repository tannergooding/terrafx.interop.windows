// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2518526C-E789-4111-A7B9-47EF328D13E6")]
    [NativeTypeName("struct IDirect3DVolumeTexture9 : IDirect3DBaseTexture9")]
    public unsafe partial struct IDirect3DVolumeTexture9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint>)(lpVtbl[1]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint>)(lpVtbl[2]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)(lpVtbl[4]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("void *")] void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)(lpVtbl[5]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, Guid*, int>)(lpVtbl[6]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), refguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, uint>)(lpVtbl[7]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint>)(lpVtbl[8]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DVolumeTexture9*, void>)(lpVtbl[9]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new D3DRESOURCETYPE GetType()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, D3DRESOURCETYPE>)(lpVtbl[10]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint SetLOD([NativeTypeName("DWORD")] uint LODNew)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, uint>)(lpVtbl[11]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), LODNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLOD()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint>)(lpVtbl[12]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint GetLevelCount()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint>)(lpVtbl[13]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutoGenFilterType(D3DTEXTUREFILTERTYPE FilterType)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[14]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), FilterType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3DTEXTUREFILTERTYPE GetAutoGenFilterType()
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, D3DTEXTUREFILTERTYPE>)(lpVtbl[15]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GenerateMipSubLevels()
        {
            ((delegate* unmanaged<IDirect3DVolumeTexture9*, void>)(lpVtbl[16]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelDesc([NativeTypeName("UINT")] uint Level, [NativeTypeName("D3DVOLUME_DESC *")] D3DVOLUME_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, D3DVOLUME_DESC*, int>)(lpVtbl[17]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolumeLevel([NativeTypeName("UINT")] uint Level, [NativeTypeName("IDirect3DVolume9 **")] IDirect3DVolume9** ppVolumeLevel)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)(lpVtbl[18]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, ppVolumeLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockBox([NativeTypeName("UINT")] uint Level, [NativeTypeName("D3DLOCKED_BOX *")] D3DLOCKED_BOX* pLockedVolume, [NativeTypeName("const D3DBOX *")] D3DBOX* pBox, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, D3DLOCKED_BOX*, D3DBOX*, uint, int>)(lpVtbl[19]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level, pLockedVolume, pBox, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockBox([NativeTypeName("UINT")] uint Level)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, uint, int>)(lpVtbl[20]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDirtyBox([NativeTypeName("const D3DBOX *")] D3DBOX* pDirtyBox)
        {
            return ((delegate* unmanaged<IDirect3DVolumeTexture9*, D3DBOX*, int>)(lpVtbl[21]))((IDirect3DVolumeTexture9*)Unsafe.AsPointer(ref this), pDirtyBox);
        }
    }
}
