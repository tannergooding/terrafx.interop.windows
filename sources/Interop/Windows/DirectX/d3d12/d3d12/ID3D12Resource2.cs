// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12Resource2.xml' path='doc/member[@name="ID3D12Resource2"]/*' />
[Guid("BE36EC3B-EA85-4AEB-A45A-E9D76404A495")]
[NativeTypeName("struct ID3D12Resource2 : ID3D12Resource1")]
[NativeInheritance("ID3D12Resource1")]
public unsafe partial struct ID3D12Resource2 : ID3D12Resource2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Resource2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, uint>)(lpVtbl[1]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, uint>)(lpVtbl[2]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, char*, int>)(lpVtbl[6]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12Resource.Map" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Map(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, void** ppData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, uint, D3D12_RANGE*, void**, int>)(lpVtbl[8]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
    }

    /// <inheritdoc cref="ID3D12Resource.Unmap" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Unmap(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, uint, D3D12_RANGE*, void>)(lpVtbl[9]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
    }

    /// <inheritdoc cref="ID3D12Resource.GetDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_RESOURCE_DESC GetDesc()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, D3D12_RESOURCE_DESC>)(lpVtbl[10]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Resource.GetGPUVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong GetGPUVirtualAddress()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, ulong>)(lpVtbl[11]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Resource.WriteToSubresource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteToSubresource(uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, uint, D3D12_BOX*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <inheritdoc cref="ID3D12Resource.ReadFromSubresource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, void*, uint, uint, uint, D3D12_BOX*, int>)(lpVtbl[13]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
    }

    /// <inheritdoc cref="ID3D12Resource.GetHeapProperties" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetHeapProperties(D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS* pHeapFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int>)(lpVtbl[14]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
    }

    /// <inheritdoc cref="ID3D12Resource1.GetProtectedResourceSession" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[15]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
    }

    /// <include file='ID3D12Resource2.xml' path='doc/member[@name="ID3D12Resource2.GetDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public D3D12_RESOURCE_DESC1 GetDesc1()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Resource2*, D3D12_RESOURCE_DESC1>)(lpVtbl[16]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12Resource1.Interface
    {
        [VtblIndex(16)]
        D3D12_RESOURCE_DESC1 GetDesc1();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("HRESULT (UINT, const D3D12_RANGE *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_RANGE*, void**, int> Map;

        [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_RANGE*, void> Unmap;

        [NativeTypeName("D3D12_RESOURCE_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RESOURCE_DESC> GetDesc;

        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetGPUVirtualAddress;

        [NativeTypeName("HRESULT (UINT, const D3D12_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_BOX*, void*, uint, uint, int> WriteToSubresource;

        [NativeTypeName("HRESULT (void *, UINT, UINT, UINT, const D3D12_BOX *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint, uint, D3D12_BOX*, int> ReadFromSubresource;

        [NativeTypeName("HRESULT (D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int> GetHeapProperties;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetProtectedResourceSession;

        [NativeTypeName("D3D12_RESOURCE_DESC1 () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RESOURCE_DESC1> GetDesc1;
    }
}
