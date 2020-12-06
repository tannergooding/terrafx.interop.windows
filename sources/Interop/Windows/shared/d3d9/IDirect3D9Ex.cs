// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("02177241-69FC-400C-8FF1-93A44DF6861D")]
    [NativeTypeName("struct IDirect3D9Ex : IDirect3D9")]
    public unsafe partial struct IDirect3D9Ex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[1]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[2]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterSoftwareDevice([NativeTypeName("void *")] void* pInitializeFunction)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, void*, int>)(lpVtbl[3]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), pInitializeFunction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint>)(lpVtbl[4]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterIdentifier([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DADAPTER_IDENTIFIER9 *")] D3DADAPTER_IDENTIFIER9* pIdentifier)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, uint, D3DADAPTER_IDENTIFIER9*, int>)(lpVtbl[5]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Flags, pIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetAdapterModeCount([NativeTypeName("UINT")] uint Adapter, D3DFORMAT Format)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DFORMAT, uint>)(lpVtbl[6]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterModes([NativeTypeName("UINT")] uint Adapter, D3DFORMAT Format, [NativeTypeName("UINT")] uint Mode, [NativeTypeName("D3DDISPLAYMODE *")] D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DFORMAT, uint, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format, Mode, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterDisplayMode([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("D3DDISPLAYMODE *")] D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceType([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DevType, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat, [NativeTypeName("BOOL")] int bWindowed)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int, int>)(lpVtbl[9]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceFormat([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, [NativeTypeName("DWORD")] uint Usage, D3DRESOURCETYPE RType, D3DFORMAT CheckFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, uint, D3DRESOURCETYPE, D3DFORMAT, int>)(lpVtbl[10]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceMultiSampleType([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SurfaceFormat, [NativeTypeName("BOOL")] int Windowed, D3DMULTISAMPLE_TYPE MultiSampleType, [NativeTypeName("DWORD *")] uint* pQualityLevels)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, int, D3DMULTISAMPLE_TYPE, uint*, int>)(lpVtbl[11]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDepthStencilMatch([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, D3DFORMAT RenderTargetFormat, D3DFORMAT DepthStencilFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[12]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceFormatConversion([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SourceFormat, D3DFORMAT TargetFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[13]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SourceFormat, TargetFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCaps([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, [NativeTypeName("D3DCAPS9 *")] D3DCAPS9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DCAPS9*, int>)(lpVtbl[14]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HMONITOR")]
        public IntPtr GetAdapterMonitor([NativeTypeName("UINT")] uint Adapter)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, IntPtr>)(lpVtbl[15]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDevice([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, [NativeTypeName("HWND")] IntPtr hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, [NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters, [NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, IntPtr, uint, D3DPRESENT_PARAMETERS*, IDirect3DDevice9**, int>)(lpVtbl[16]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetAdapterModeCountEx([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint>)(lpVtbl[17]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterModesEx([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter, [NativeTypeName("UINT")] uint Mode, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint, D3DDISPLAYMODEEX*, int>)(lpVtbl[18]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter, Mode, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterDisplayModeEx([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pMode, [NativeTypeName("D3DDISPLAYROTATION *")] D3DDISPLAYROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[19]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode, pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceEx([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DeviceType, [NativeTypeName("HWND")] IntPtr hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, [NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pFullscreenDisplayMode, [NativeTypeName("IDirect3DDevice9Ex **")] IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, D3DDEVTYPE, IntPtr, uint, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, IDirect3DDevice9Ex**, int>)(lpVtbl[20]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapterLUID([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("LUID *")] LUID* pLUID)
        {
            return ((delegate* unmanaged<IDirect3D9Ex*, uint, LUID*, int>)(lpVtbl[21]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pLUID);
        }
    }
}
