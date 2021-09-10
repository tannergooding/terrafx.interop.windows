// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9727A022-CF1D-4DDA-9EBA-EFFA653FC506")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData")]
    [NativeInheritance("ID3D12DeviceRemovedExtendedData")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedData1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutoBreadcrumbsOutput(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT*, int>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageFaultAllocationOutput(D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, D3D12_DRED_PAGE_FAULT_OUTPUT*, int>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutoBreadcrumbsOutput1(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1*, int>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageFaultAllocationOutput1(D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, D3D12_DRED_PAGE_FAULT_OUTPUT1*, int>)(lpVtbl[6]))((ID3D12DeviceRemovedExtendedData1*)Unsafe.AsPointer(ref this), pOutput);
        }
    }
}
