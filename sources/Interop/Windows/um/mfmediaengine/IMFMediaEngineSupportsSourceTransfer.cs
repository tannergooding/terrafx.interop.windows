// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A724B056-1B2E-4642-A6F3-DB9420C52908")]
    [NativeTypeName("struct IMFMediaEngineSupportsSourceTransfer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineSupportsSourceTransfer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, uint>)(lpVtbl[1]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, uint>)(lpVtbl[2]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldTransferSource([NativeTypeName("BOOL *")] int* pfShouldTransfer)
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, int*, int>)(lpVtbl[3]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pfShouldTransfer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int DetachMediaSource(IMFByteStream** ppByteStream, IMFMediaSource** ppMediaSource, IMFMediaSourceExtension** ppMSE)
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)(lpVtbl[4]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), ppByteStream, ppMediaSource, ppMSE);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AttachMediaSource(IMFByteStream* pByteStream, IMFMediaSource* pMediaSource, IMFMediaSourceExtension* pMSE)
        {
            return ((delegate* unmanaged<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)(lpVtbl[5]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pByteStream, pMediaSource, pMSE);
        }
    }
}
