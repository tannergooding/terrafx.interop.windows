// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10")]
    public unsafe partial struct IDXGIDevice4
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDevice4* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDevice4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDevice4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIDevice4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIDevice4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIDevice4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIDevice4* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAdapter(IDXGIDevice4* pThis, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** pAdapter);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurface(IDXGIDevice4* pThis, [NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, [NativeTypeName("UINT")] uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, [NativeTypeName("IDXGISurface **")] IDXGISurface** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryResourceResidency(IDXGIDevice4* pThis, [NativeTypeName("IUnknown *const *")] IUnknown** ppResources, [NativeTypeName("DXGI_RESIDENCY *")] DXGI_RESIDENCY* pResidencyStatus, [NativeTypeName("UINT")] uint NumResources);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGPUThreadPriority(IDXGIDevice4* pThis, [NativeTypeName("INT")] int Priority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGPUThreadPriority(IDXGIDevice4* pThis, [NativeTypeName("INT *")] int* pPriority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaximumFrameLatency(IDXGIDevice4* pThis, [NativeTypeName("UINT")] uint MaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumFrameLatency(IDXGIDevice4* pThis, [NativeTypeName("UINT *")] uint* pMaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources(IDXGIDevice4* pThis, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReclaimResources(IDXGIDevice4* pThis, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, [NativeTypeName("BOOL *")] int* pDiscarded);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueSetEvent(IDXGIDevice4* pThis, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Trim(IDXGIDevice4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources1(IDXGIDevice4* pThis, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReclaimResources1(IDXGIDevice4* pThis, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, [NativeTypeName("DXGI_RECLAIM_RESOURCE_RESULTS *")] DXGI_RECLAIM_RESOURCE_RESULTS* pResults);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapter([NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** pAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAdapter>(lpVtbl->GetAdapter)((IDXGIDevice4*)Unsafe.AsPointer(ref this), pAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, [NativeTypeName("UINT")] uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, [NativeTypeName("IDXGISurface **")] IDXGISurface** ppSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)((IDXGIDevice4*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryResourceResidency([NativeTypeName("IUnknown *const *")] IUnknown** ppResources, [NativeTypeName("DXGI_RESIDENCY *")] DXGI_RESIDENCY* pResidencyStatus, [NativeTypeName("UINT")] uint NumResources)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryResourceResidency>(lpVtbl->QueryResourceResidency)((IDXGIDevice4*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority([NativeTypeName("INT")] int Priority)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGPUThreadPriority>(lpVtbl->SetGPUThreadPriority)((IDXGIDevice4*)Unsafe.AsPointer(ref this), Priority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority([NativeTypeName("INT *")] int* pPriority)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGPUThreadPriority>(lpVtbl->GetGPUThreadPriority)((IDXGIDevice4*)Unsafe.AsPointer(ref this), pPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)((IDXGIDevice4*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)((IDXGIDevice4*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority)
        {
            return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, [NativeTypeName("BOOL *")] int* pDiscarded)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReclaimResources>(lpVtbl->ReclaimResources)((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueSetEvent([NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnqueueSetEvent>(lpVtbl->EnqueueSetEvent)((IDXGIDevice4*)Unsafe.AsPointer(ref this), hEvent);
        }

        public void Trim()
        {
            Marshal.GetDelegateForFunctionPointer<_Trim>(lpVtbl->Trim)((IDXGIDevice4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources1([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_OfferResources1>(lpVtbl->OfferResources1)((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources1([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource *const *")] IDXGIResource** ppResources, [NativeTypeName("DXGI_RECLAIM_RESOURCE_RESULTS *")] DXGI_RECLAIM_RESOURCE_RESULTS* pResults)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReclaimResources1>(lpVtbl->ReclaimResources1)((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pResults);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("HRESULT (IDXGIAdapter **) __attribute__((stdcall))")]
            public IntPtr GetAdapter;

            [NativeTypeName("HRESULT (const DXGI_SURFACE_DESC *, UINT, DXGI_USAGE, const DXGI_SHARED_RESOURCE *, IDXGISurface **) __attribute__((stdcall))")]
            public IntPtr CreateSurface;

            [NativeTypeName("HRESULT (IUnknown *const *, DXGI_RESIDENCY *, UINT) __attribute__((stdcall))")]
            public IntPtr QueryResourceResidency;

            [NativeTypeName("HRESULT (INT) __attribute__((stdcall))")]
            public IntPtr SetGPUThreadPriority;

            [NativeTypeName("HRESULT (INT *) __attribute__((stdcall))")]
            public IntPtr GetGPUThreadPriority;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetMaximumFrameLatency;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetMaximumFrameLatency;

            [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY) __attribute__((stdcall))")]
            public IntPtr OfferResources;

            [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, BOOL *) __attribute__((stdcall))")]
            public IntPtr ReclaimResources;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public IntPtr EnqueueSetEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Trim;

            [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY, UINT) __attribute__((stdcall))")]
            public IntPtr OfferResources1;

            [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, DXGI_RECLAIM_RESOURCE_RESULTS *) __attribute__((stdcall))")]
            public IntPtr ReclaimResources1;
        }
    }
}