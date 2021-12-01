// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("9B7E4C04-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10Texture2D : ID3D10Resource")]
[NativeInheritance("ID3D10Resource")]
public unsafe partial struct ID3D10Texture2D : ID3D10Texture2D.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, uint>)(lpVtbl[1]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, uint>)(lpVtbl[2]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D10Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D10Texture2D*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), ppDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetType(D3D10_RESOURCE_DIMENSION* rType)
    {
        ((delegate* unmanaged<ID3D10Texture2D*, D3D10_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), rType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetEvictionPriority(uint EvictionPriority)
    {
        ((delegate* unmanaged<ID3D10Texture2D*, uint, void>)(lpVtbl[8]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), EvictionPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetEvictionPriority()
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, uint>)(lpVtbl[9]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Map(uint Subresource, D3D10_MAP MapType, uint MapFlags, D3D10_MAPPED_TEXTURE2D* pMappedTex2D)
    {
        return ((delegate* unmanaged<ID3D10Texture2D*, uint, D3D10_MAP, uint, D3D10_MAPPED_TEXTURE2D*, int>)(lpVtbl[10]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), Subresource, MapType, MapFlags, pMappedTex2D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void Unmap(uint Subresource)
    {
        ((delegate* unmanaged<ID3D10Texture2D*, uint, void>)(lpVtbl[11]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), Subresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void GetDesc(D3D10_TEXTURE2D_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D10Texture2D*, D3D10_TEXTURE2D_DESC*, void>)(lpVtbl[12]))((ID3D10Texture2D*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface : ID3D10Resource.Interface
    {
        [VtblIndex(10)]
        HRESULT Map(uint Subresource, D3D10_MAP MapType, uint MapFlags, D3D10_MAPPED_TEXTURE2D* pMappedTex2D);

        [VtblIndex(11)]
        void Unmap(uint Subresource);

        [VtblIndex(12)]
        void GetDesc(D3D10_TEXTURE2D_DESC* pDesc);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (ID3D10Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("void (D3D10_RESOURCE_DIMENSION *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D10_RESOURCE_DIMENSION*, void> GetType;

        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetEvictionPriority;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetEvictionPriority;

        [NativeTypeName("HRESULT (UINT, D3D10_MAP, UINT, D3D10_MAPPED_TEXTURE2D *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D10_MAP, uint, D3D10_MAPPED_TEXTURE2D*, int> Map;

        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> Unmap;

        [NativeTypeName("void (D3D10_TEXTURE2D_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_TEXTURE2D_DESC*, void> GetDesc;
    }
}