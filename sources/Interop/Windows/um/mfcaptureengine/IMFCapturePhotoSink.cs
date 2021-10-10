// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2D43CC8-48BB-4AA7-95DB-10C06977E777")]
    [NativeTypeName("struct IMFCapturePhotoSink : IMFCaptureSink")]
    [NativeInheritance("IMFCaptureSink")]
    public unsafe partial struct IMFCapturePhotoSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, uint>)(lpVtbl[1]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, uint>)(lpVtbl[2]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, int>)(lpVtbl[6]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllStreams()
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, int>)(lpVtbl[7]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputFileName([NativeTypeName("LPCWSTR")] ushort* fileName)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, ushort*, int>)(lpVtbl[8]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetSampleCallback(IMFCaptureEngineOnSampleCallback* pCallback)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, IMFCaptureEngineOnSampleCallback*, int>)(lpVtbl[9]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputByteStream(IMFByteStream* pByteStream)
        {
            return ((delegate* unmanaged<IMFCapturePhotoSink*, IMFByteStream*, int>)(lpVtbl[10]))((IMFCapturePhotoSink*)Unsafe.AsPointer(ref this), pByteStream);
        }
    }
}
