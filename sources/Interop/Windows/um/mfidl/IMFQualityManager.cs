// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D009D86-5B9F-4115-B1FC-9F80D52AB8AB")]
    [NativeTypeName("struct IMFQualityManager : IUnknown")]
    public unsafe partial struct IMFQualityManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFQualityManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFQualityManager*, uint>)(lpVtbl[1]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFQualityManager*, uint>)(lpVtbl[2]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyTopology(IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopology*, int>)(lpVtbl[3]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyPresentationClock(IMFPresentationClock* pClock)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFPresentationClock*, int>)(lpVtbl[4]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyProcessInput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lInputIndex, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[5]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lInputIndex, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyProcessOutput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lOutputIndex, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[6]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lOutputIndex, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyQualityEvent(IUnknown* pObject, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IUnknown*, IMFMediaEvent*, int>)(lpVtbl[7]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pObject, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFQualityManager*, int>)(lpVtbl[8]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }
    }
}
