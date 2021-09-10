// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CA86AA50-C46E-429E-AB27-16D6AC6844CB")]
    [NativeTypeName("struct IMFSampleGrabberSinkCallback2 : IMFSampleGrabberSinkCallback")]
    [NativeInheritance("IMFSampleGrabberSinkCallback")]
    public unsafe partial struct IMFSampleGrabberSinkCallback2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, uint>)(lpVtbl[1]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, uint>)(lpVtbl[2]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, long, long, int>)(lpVtbl[3]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[4]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[5]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[6]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, long, float, int>)(lpVtbl[7]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetPresentationClock(IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, IMFPresentationClock*, int>)(lpVtbl[8]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int OnProcessSample([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, Guid*, uint, long, long, byte*, uint, int>)(lpVtbl[9]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int OnShutdown()
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, int>)(lpVtbl[10]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int OnProcessSampleEx([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize, IMFAttributes* pAttributes)
        {
            return ((delegate* unmanaged<IMFSampleGrabberSinkCallback2*, Guid*, uint, long, long, byte*, uint, IMFAttributes*, int>)(lpVtbl[11]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize, pAttributes);
        }
    }
}
