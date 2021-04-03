// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5")]
    [NativeTypeName("struct IMFMediaEngineNotify : IUnknown")]
    public unsafe partial struct IMFMediaEngineNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineNotify*, uint>)(lpVtbl[1]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineNotify*, uint>)(lpVtbl[2]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EventNotify([NativeTypeName("DWORD")] uint @event, [NativeTypeName("DWORD_PTR")] nuint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged<IMFMediaEngineNotify*, uint, nuint, uint, int>)(lpVtbl[3]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this), @event, param1, param2);
        }
    }
}
