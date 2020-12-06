// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("91886CAF-1C3D-4D2E-A0AB-3E4C7D8D3303")]
    [NativeTypeName("struct IDirect3DSwapChain9Ex : IDirect3DSwapChain9")]
    public unsafe partial struct IDirect3DSwapChain9Ex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, uint>)(lpVtbl[1]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, uint>)(lpVtbl[2]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] IntPtr hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, RECT*, RECT*, IntPtr, RGNDATA*, uint, int>)(lpVtbl[3]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrontBufferData([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)(lpVtbl[4]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pDestSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackBuffer([NativeTypeName("UINT")] uint iBackBuffer, D3DBACKBUFFER_TYPE Type, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[5]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), iBackBuffer, Type, ppBackBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterStatus([NativeTypeName("D3DRASTER_STATUS *")] D3DRASTER_STATUS* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, D3DRASTER_STATUS*, int>)(lpVtbl[6]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pRasterStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("D3DDISPLAYMODE *")] D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)(lpVtbl[8]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentParameters([NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, uint*, int>)(lpVtbl[10]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentStats([NativeTypeName("D3DPRESENTSTATS *")] D3DPRESENTSTATS* pPresentationStatistics)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, D3DPRESENTSTATS*, int>)(lpVtbl[11]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pPresentationStatistics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeEx([NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pMode, [NativeTypeName("D3DDISPLAYROTATION *")] D3DDISPLAYROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9Ex*, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[12]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pMode, pRotation);
        }
    }
}
