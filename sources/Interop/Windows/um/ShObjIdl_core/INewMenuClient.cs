// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCB07FDC-3BB5-451C-90BE-966644FED7B0")]
    [NativeTypeName("struct INewMenuClient : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INewMenuClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INewMenuClient*, Guid*, void**, int>)(lpVtbl[0]))((INewMenuClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INewMenuClient*, uint>)(lpVtbl[1]))((INewMenuClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INewMenuClient*, uint>)(lpVtbl[2]))((INewMenuClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IncludeItems([NativeTypeName("NMCII_FLAGS *")] int* pflags)
        {
            return ((delegate* unmanaged<INewMenuClient*, int*, int>)(lpVtbl[3]))((INewMenuClient*)Unsafe.AsPointer(ref this), pflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SelectAndEditItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem, [NativeTypeName("NMCSAEI_FLAGS")] int flags)
        {
            return ((delegate* unmanaged<INewMenuClient*, ITEMIDLIST*, int, int>)(lpVtbl[4]))((INewMenuClient*)Unsafe.AsPointer(ref this), pidlItem, flags);
        }
    }
}
