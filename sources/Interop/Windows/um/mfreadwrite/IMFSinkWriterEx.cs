// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("588D72AB-5BC1-496A-8714-B70617141B25")]
    public unsafe partial struct IMFSinkWriterEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint>)(lpVtbl[1]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint>)(lpVtbl[2]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("IMFMediaType *")] IMFMediaType* pTargetMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamIndex)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, IMFMediaType*, uint*, int>)(lpVtbl[3]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), pTargetMediaType, pdwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pInputMediaType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pEncodingParameters)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, IMFMediaType*, IMFAttributes*, int>)(lpVtbl[4]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pInputMediaType, pEncodingParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginWriting()
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, int>)(lpVtbl[5]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, IMFSample*, int>)(lpVtbl[6]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendStreamTick([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LONGLONG")] long llTimestamp)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, long, int>)(lpVtbl[7]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, llTimestamp);
        }

        [return: NativeTypeName("HRESULT")]
        public int PlaceMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, void*, int>)(lpVtbl[8]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyEndOfSegment([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, int>)(lpVtbl[9]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, int>)(lpVtbl[10]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finalize()
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, int>)(lpVtbl[11]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, Guid*, Guid*, void**, int>)(lpVtbl[12]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatistics([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("MF_SINK_WRITER_STATISTICS *")] MF_SINK_WRITER_STATISTICS* pStats)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, MF_SINK_WRITER_STATISTICS*, int>)(lpVtbl[13]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, [NativeTypeName("GUID *")] Guid* pGuidCategory, [NativeTypeName("IMFTransform **")] IMFTransform** ppTransform)
        {
            return ((delegate* stdcall<IMFSinkWriterEx*, uint, uint, Guid*, IMFTransform**, int>)(lpVtbl[14]))((IMFSinkWriterEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
        }
    }
}