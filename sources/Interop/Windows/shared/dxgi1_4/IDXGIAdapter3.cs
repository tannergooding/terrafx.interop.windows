// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("645967A4-1392-4310-A798-8053CE3E93FD")]
    [NativeTypeName("struct IDXGIAdapter3 : IDXGIAdapter2")]
    [NativeInheritance("IDXGIAdapter2")]
    public unsafe partial struct IDXGIAdapter3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, uint>)(lpVtbl[1]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, uint>)(lpVtbl[2]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs([NativeTypeName("UINT")] uint Output, IDXGIOutput** ppOutput)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, uint, IDXGIOutput**, int>)(lpVtbl[7]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), Output, ppOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_ADAPTER_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, DXGI_ADAPTER_DESC*, int>)(lpVtbl[8]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, LARGE_INTEGER* pUMDVersion)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, Guid*, LARGE_INTEGER*, int>)(lpVtbl[9]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(DXGI_ADAPTER_DESC1* pDesc)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, DXGI_ADAPTER_DESC1*, int>)(lpVtbl[10]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc2(DXGI_ADAPTER_DESC2* pDesc)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, DXGI_ADAPTER_DESC2*, int>)(lpVtbl[11]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterHardwareContentProtectionTeardownStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, IntPtr, uint*, int>)(lpVtbl[12]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void UnregisterHardwareContentProtectionTeardownStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IDXGIAdapter3*, uint, void>)(lpVtbl[13]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int QueryVideoMemoryInfo([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, uint, DXGI_MEMORY_SEGMENT_GROUP, DXGI_QUERY_VIDEO_MEMORY_INFO*, int>)(lpVtbl[14]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetVideoMemoryReservation([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, uint, DXGI_MEMORY_SEGMENT_GROUP, ulong, int>)(lpVtbl[15]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, Reservation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterVideoMemoryBudgetChangeNotificationEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IDXGIAdapter3*, IntPtr, uint*, int>)(lpVtbl[16]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void UnregisterVideoMemoryBudgetChangeNotification([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IDXGIAdapter3*, uint, void>)(lpVtbl[17]))((IDXGIAdapter3*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
