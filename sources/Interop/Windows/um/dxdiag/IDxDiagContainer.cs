// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDxDiagContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxDiagContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint>)(lpVtbl[1]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint>)(lpVtbl[2]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint*, int>)(lpVtbl[3]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[4]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszContainer, cchContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetChildContainer([NativeTypeName("LPCWSTR")] ushort* pwszContainer, IDxDiagContainer** ppInstance)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, ushort*, IDxDiagContainer**, int>)(lpVtbl[5]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszContainer, ppInstance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint*, int>)(lpVtbl[6]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszPropName, cchPropName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetProp([NativeTypeName("LPCWSTR")] ushort* pwszPropName, VARIANT* pvarProp)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszPropName, pvarProp);
        }
    }
}
