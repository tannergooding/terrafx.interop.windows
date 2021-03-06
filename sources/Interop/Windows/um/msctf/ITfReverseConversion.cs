// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A415E162-157D-417D-8A8C-0AB26C7D2781")]
    [NativeTypeName("struct ITfReverseConversion : IUnknown")]
    public unsafe partial struct ITfReverseConversion
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfReverseConversion*, Guid*, void**, int>)(lpVtbl[0]))((ITfReverseConversion*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfReverseConversion*, uint>)(lpVtbl[1]))((ITfReverseConversion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfReverseConversion*, uint>)(lpVtbl[2]))((ITfReverseConversion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoReverseConversion([NativeTypeName("LPCWSTR")] ushort* lpstr, ITfReverseConversionList** ppList)
        {
            return ((delegate* unmanaged<ITfReverseConversion*, ushort*, ITfReverseConversionList**, int>)(lpVtbl[3]))((ITfReverseConversion*)Unsafe.AsPointer(ref this), lpstr, ppList);
        }
    }
}
