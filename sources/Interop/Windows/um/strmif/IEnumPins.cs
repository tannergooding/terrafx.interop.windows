// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86892-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IEnumPins : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumPins
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumPins*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPins*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumPins*, uint>)(lpVtbl[1]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumPins*, uint>)(lpVtbl[2]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cPins, IPin** ppPins, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumPins*, uint, IPin**, uint*, int>)(lpVtbl[3]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins, ppPins, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cPins)
        {
            return ((delegate* unmanaged<IEnumPins*, uint, int>)(lpVtbl[4]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumPins*, int>)(lpVtbl[5]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumPins** ppEnum)
        {
            return ((delegate* unmanaged<IEnumPins*, IEnumPins**, int>)(lpVtbl[6]))((IEnumPins*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
