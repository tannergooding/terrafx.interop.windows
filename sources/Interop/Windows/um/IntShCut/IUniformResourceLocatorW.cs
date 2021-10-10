// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CABB0DA0-DA57-11CF-9974-0020AFD79762")]
    [NativeTypeName("struct IUniformResourceLocatorW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUniformResourceLocatorW
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, Guid*, void**, int>)(lpVtbl[0]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, uint>)(lpVtbl[1]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, uint>)(lpVtbl[2]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetURL([NativeTypeName("LPCWSTR")] ushort* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, ushort*, uint, int>)(lpVtbl[3]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), pcszURL, dwInFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, ushort**, int>)(lpVtbl[4]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), ppszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOW")] urlinvokecommandinfoW* purlici)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorW*, urlinvokecommandinfoW*, int>)(lpVtbl[5]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), purlici);
        }
    }
}
