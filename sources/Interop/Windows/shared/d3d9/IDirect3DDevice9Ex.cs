// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B18B10CE-2649-405A-870F-95F777D4313A")]
    [NativeTypeName("struct IDirect3DDevice9Ex : IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9Ex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[1]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[2]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TestCooperativeLevel()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[3]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetAvailableTextureMem()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[4]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EvictManagedResources()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[5]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDirect3D([NativeTypeName("IDirect3D9 **")] IDirect3D9** ppD3D9)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3D9**, int>)(lpVtbl[6]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppD3D9);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCaps([NativeTypeName("D3DCAPS9 *")] D3DCAPS9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCAPS9*, int>)(lpVtbl[7]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("D3DDISPLAYMODE *")] D3DDISPLAYMODE* pMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCreationParameters([NativeTypeName("D3DDEVICE_CREATION_PARAMETERS *")] D3DDEVICE_CREATION_PARAMETERS* pParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DDEVICE_CREATION_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCursorProperties([NativeTypeName("UINT")] uint XHotSpot, [NativeTypeName("UINT")] uint YHotSpot, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pCursorBitmap)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)(lpVtbl[10]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), XHotSpot, YHotSpot, pCursorBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int, uint, void>)(lpVtbl[11]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), X, Y, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int ShowCursor([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[12]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAdditionalSwapChain([NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters, [NativeTypeName("IDirect3DSwapChain9 **")] IDirect3DSwapChain9** pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, IDirect3DSwapChain9**, int>)(lpVtbl[13]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters, pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("IDirect3DSwapChain9 **")] IDirect3DSwapChain9** pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)(lpVtbl[14]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetNumberOfSwapChains()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint>)(lpVtbl[15]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[16]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] IntPtr hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, RECT*, IntPtr, RGNDATA*, int>)(lpVtbl[17]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackBuffer([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("UINT")] uint iBackBuffer, D3DBACKBUFFER_TYPE Type, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[18]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, iBackBuffer, Type, ppBackBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterStatus([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("D3DRASTER_STATUS *")] D3DRASTER_STATUS* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DRASTER_STATUS*, int>)(lpVtbl[19]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pRasterStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDialogBoxMode([NativeTypeName("BOOL")] int bEnableDialogs)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[20]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bEnableDialogs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetGammaRamp([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DGAMMARAMP*, void>)(lpVtbl[21]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, Flags, pRamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetGammaRamp([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DGAMMARAMP*, void>)(lpVtbl[22]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pRamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, [NativeTypeName("UINT")] uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DTexture9 **")] IDirect3DTexture9** ppTexture, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DTexture9**, IntPtr*, int>)(lpVtbl[23]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVolumeTexture([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, [NativeTypeName("UINT")] uint Depth, [NativeTypeName("UINT")] uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DVolumeTexture9 **")] IDirect3DVolumeTexture9** ppVolumeTexture, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9**, IntPtr*, int>)(lpVtbl[24]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubeTexture([NativeTypeName("UINT")] uint EdgeLength, [NativeTypeName("UINT")] uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DCubeTexture9 **")] IDirect3DCubeTexture9** ppCubeTexture, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9**, IntPtr*, int>)(lpVtbl[25]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer([NativeTypeName("UINT")] uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3DPOOL Pool, [NativeTypeName("IDirect3DVertexBuffer9 **")] IDirect3DVertexBuffer9** ppVertexBuffer, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, D3DPOOL, IDirect3DVertexBuffer9**, IntPtr*, int>)(lpVtbl[26]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIndexBuffer([NativeTypeName("UINT")] uint Length, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DIndexBuffer9 **")] IDirect3DIndexBuffer9** ppIndexBuffer, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9**, IntPtr*, int>)(lpVtbl[27]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTarget([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, IntPtr*, int>)(lpVtbl[28]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilSurface([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, IntPtr*, int>)(lpVtbl[29]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSurface([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDestinationSurface, [NativeTypeName("const POINT *")] POINT* pDestPoint)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, POINT*, int>)(lpVtbl[30]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTexture([NativeTypeName("IDirect3DBaseTexture9 *")] IDirect3DBaseTexture9* pSourceTexture, [NativeTypeName("IDirect3DBaseTexture9 *")] IDirect3DBaseTexture9* pDestinationTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)(lpVtbl[31]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceTexture, pDestinationTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTargetData([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pRenderTarget, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)(lpVtbl[32]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRenderTarget, pDestSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrontBufferData([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)(lpVtbl[33]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pDestSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StretchRect([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3DTEXTUREFILTERTYPE Filter)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, RECT*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[34]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ColorFill([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, RECT*, uint, int>)(lpVtbl[35]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSurface, pRect, color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffscreenPlainSurface([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, IntPtr*, int>)(lpVtbl[36]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)(lpVtbl[37]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), RenderTargetIndex, pRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)(lpVtbl[38]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), RenderTargetIndex, ppRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDepthStencilSurface([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pNewZStencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)(lpVtbl[39]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pNewZStencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDepthStencilSurface([NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppZStencilSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)(lpVtbl[40]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppZStencilSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[41]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[42]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3DRECT* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DRECT*, uint, uint, float, uint, int>)(lpVtbl[43]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Count, pRects, Flags, Color, Z, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[44]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[45]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MultiplyTransform(D3DTRANSFORMSTATETYPE param0, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[46]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVIEWPORT9*, int>)(lpVtbl[47]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pViewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewport([NativeTypeName("D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVIEWPORT9*, int>)(lpVtbl[48]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pViewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DMATERIAL9*, int>)(lpVtbl[49]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaterial([NativeTypeName("D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DMATERIAL9*, int>)(lpVtbl[50]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3DLIGHT9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DLIGHT9*, int>)(lpVtbl[51]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("D3DLIGHT9 *")] D3DLIGHT9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DLIGHT9*, int>)(lpVtbl[52]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] int Enable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int, int>)(lpVtbl[53]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] int* pEnable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, int>)(lpVtbl[54]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, int>)(lpVtbl[55]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("float *")] float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, int>)(lpVtbl[56]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DRENDERSTATETYPE, uint, int>)(lpVtbl[57]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DRENDERSTATETYPE, uint*, int>)(lpVtbl[58]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), State, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStateBlock(D3DSTATEBLOCKTYPE Type, [NativeTypeName("IDirect3DStateBlock9 **")] IDirect3DStateBlock9** ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DSTATEBLOCKTYPE, IDirect3DStateBlock9**, int>)(lpVtbl[59]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Type, ppSB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginStateBlock()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[60]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndStateBlock([NativeTypeName("IDirect3DStateBlock9 **")] IDirect3DStateBlock9** ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)(lpVtbl[61]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppSB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCLIPSTATUS9*, int>)(lpVtbl[62]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipStatus([NativeTypeName("D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DCLIPSTATUS9*, int>)(lpVtbl[63]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9 **")] IDirect3DBaseTexture9** ppTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)(lpVtbl[64]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, ppTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9 *")] IDirect3DBaseTexture9* pTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)(lpVtbl[65]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, pTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DTEXTURESTAGESTATETYPE, uint*, int>)(lpVtbl[66]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, Type, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DTEXTURESTAGESTATETYPE, uint, int>)(lpVtbl[67]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Stage, Type, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DSAMPLERSTATETYPE, uint*, int>)(lpVtbl[68]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Sampler, Type, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DSAMPLERSTATETYPE, uint, int>)(lpVtbl[69]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Sampler, Type, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[70]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pNumPasses);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPaletteEntries([NativeTypeName("UINT")] uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, PALETTEENTRY*, int>)(lpVtbl[71]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries([NativeTypeName("UINT")] uint PaletteNumber, [NativeTypeName("PALETTEENTRY *")] PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, PALETTEENTRY*, int>)(lpVtbl[72]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTexturePalette([NativeTypeName("UINT")] uint PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[73]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTexturePalette([NativeTypeName("UINT *")] uint* PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[74]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, int>)(lpVtbl[75]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScissorRect([NativeTypeName("RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, int>)(lpVtbl[76]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSoftwareVertexProcessing([NativeTypeName("BOOL")] int bSoftware)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[77]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), bSoftware);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetSoftwareVertexProcessing()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int>)(lpVtbl[78]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNPatchMode(float nSegments)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, float, int>)(lpVtbl[79]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), nSegments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetNPatchMode()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, float>)(lpVtbl[80]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, [NativeTypeName("UINT")] uint StartVertex, [NativeTypeName("UINT")] uint PrimitiveCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, uint, int>)(lpVtbl[81]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, StartVertex, PrimitiveCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitive(D3DPRIMITIVETYPE param0, [NativeTypeName("INT")] int BaseVertexIndex, [NativeTypeName("UINT")] uint MinVertexIndex, [NativeTypeName("UINT")] uint NumVertices, [NativeTypeName("UINT")] uint startIndex, [NativeTypeName("UINT")] uint primCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, int, uint, uint, uint, uint, int>)(lpVtbl[82]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, [NativeTypeName("UINT")] uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, [NativeTypeName("UINT")] uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, void*, uint, int>)(lpVtbl[83]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, [NativeTypeName("UINT")] uint MinVertexIndex, [NativeTypeName("UINT")] uint NumVertices, [NativeTypeName("UINT")] uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3DFORMAT IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, [NativeTypeName("UINT")] uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRIMITIVETYPE, uint, uint, uint, void*, D3DFORMAT, void*, uint, int>)(lpVtbl[84]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessVertices([NativeTypeName("UINT")] uint SrcStartIndex, [NativeTypeName("UINT")] uint DestIndex, [NativeTypeName("UINT")] uint VertexCount, [NativeTypeName("IDirect3DVertexBuffer9 *")] IDirect3DVertexBuffer9* pDestBuffer, [NativeTypeName("IDirect3DVertexDeclaration9 *")] IDirect3DVertexDeclaration9* pVertexDecl, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)(lpVtbl[85]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pVertexElements, [NativeTypeName("IDirect3DVertexDeclaration9 **")] IDirect3DVertexDeclaration9** ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DVERTEXELEMENT9*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[86]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pVertexElements, ppDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9 *")] IDirect3DVertexDeclaration9* pDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)(lpVtbl[87]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9 **")] IDirect3DVertexDeclaration9** ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[88]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFVF([NativeTypeName("DWORD")] uint FVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[89]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), FVF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[90]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFVF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DVertexShader9 **")] IDirect3DVertexShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)(lpVtbl[91]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShader([NativeTypeName("IDirect3DVertexShader9 *")] IDirect3DVertexShader9* pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)(lpVtbl[92]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShader([NativeTypeName("IDirect3DVertexShader9 **")] IDirect3DVertexShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)(lpVtbl[93]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantF([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, [NativeTypeName("UINT")] uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[94]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantF([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("float *")] float* pConstantData, [NativeTypeName("UINT")] uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[95]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantI([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, [NativeTypeName("UINT")] uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[96]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantI([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("int *")] int* pConstantData, [NativeTypeName("UINT")] uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[97]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantB([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, [NativeTypeName("UINT")] uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[98]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantB([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, [NativeTypeName("UINT")] uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[99]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSource([NativeTypeName("UINT")] uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9 *")] IDirect3DVertexBuffer9* pStreamData, [NativeTypeName("UINT")] uint OffsetInBytes, [NativeTypeName("UINT")] uint Stride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)(lpVtbl[100]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, pStreamData, OffsetInBytes, Stride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSource([NativeTypeName("UINT")] uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9 **")] IDirect3DVertexBuffer9** ppStreamData, [NativeTypeName("UINT *")] uint* pOffsetInBytes, [NativeTypeName("UINT *")] uint* pStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)(lpVtbl[101]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, ppStreamData, pOffsetInBytes, pStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSourceFreq([NativeTypeName("UINT")] uint StreamNumber, [NativeTypeName("UINT")] uint Setting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, int>)(lpVtbl[102]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, Setting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSourceFreq([NativeTypeName("UINT")] uint StreamNumber, [NativeTypeName("UINT *")] uint* pSetting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint*, int>)(lpVtbl[103]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StreamNumber, pSetting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIndices([NativeTypeName("IDirect3DIndexBuffer9 *")] IDirect3DIndexBuffer9* pIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)(lpVtbl[104]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pIndexData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndices([NativeTypeName("IDirect3DIndexBuffer9 **")] IDirect3DIndexBuffer9** ppIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)(lpVtbl[105]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppIndexData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DPixelShader9 **")] IDirect3DPixelShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)(lpVtbl[106]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader([NativeTypeName("IDirect3DPixelShader9 *")] IDirect3DPixelShader9* pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)(lpVtbl[107]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShader([NativeTypeName("IDirect3DPixelShader9 **")] IDirect3DPixelShader9** ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)(lpVtbl[108]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantF([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, [NativeTypeName("UINT")] uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[109]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantF([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("float *")] float* pConstantData, [NativeTypeName("UINT")] uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, uint, int>)(lpVtbl[110]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantI([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, [NativeTypeName("UINT")] uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[111]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantI([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("int *")] int* pConstantData, [NativeTypeName("UINT")] uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[112]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantB([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, [NativeTypeName("UINT")] uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[113]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantB([NativeTypeName("UINT")] uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, [NativeTypeName("UINT")] uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int*, uint, int>)(lpVtbl[114]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawRectPatch([NativeTypeName("UINT")] uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DRECTPATCH_INFO* pRectPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, D3DRECTPATCH_INFO*, int>)(lpVtbl[115]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pRectPatchInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawTriPatch([NativeTypeName("UINT")] uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DTRIPATCH_INFO* pTriPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, float*, D3DTRIPATCH_INFO*, int>)(lpVtbl[116]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pTriPatchInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeletePatch([NativeTypeName("UINT")] uint Handle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[117]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Handle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery(D3DQUERYTYPE Type, [NativeTypeName("IDirect3DQuery9 **")] IDirect3DQuery9** ppQuery)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DQUERYTYPE, IDirect3DQuery9**, int>)(lpVtbl[118]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Type, ppQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConvolutionMonoKernel([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("float *")] float* rows, [NativeTypeName("float *")] float* columns)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)(lpVtbl[119]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), width, height, rows, columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComposeRects([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSrc, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDst, [NativeTypeName("IDirect3DVertexBuffer9 *")] IDirect3DVertexBuffer9* pSrcRectDescs, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("IDirect3DVertexBuffer9 *")] IDirect3DVertexBuffer9* pDstRectDescs, D3DCOMPOSERECTSOP Operation, int Xoffset, int Yoffset)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, D3DCOMPOSERECTSOP, int, int, int>)(lpVtbl[120]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PresentEx([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, [NativeTypeName("HWND")] IntPtr hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, RECT*, RECT*, IntPtr, RGNDATA*, uint, int>)(lpVtbl[121]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority([NativeTypeName("INT *")] int* pPriority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int*, int>)(lpVtbl[122]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority([NativeTypeName("INT")] int Priority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, int, int>)(lpVtbl[123]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank([NativeTypeName("UINT")] uint iSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[124]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckResourceResidency([NativeTypeName("IDirect3DResource9 **")] IDirect3DResource9** pResourceArray, [NativeTypeName("UINT32")] uint NumResources)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)(lpVtbl[125]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pResourceArray, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, int>)(lpVtbl[126]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint*, int>)(lpVtbl[127]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceState([NativeTypeName("HWND")] IntPtr hDestinationWindow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, IntPtr, int>)(lpVtbl[128]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), hDestinationWindow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetEx([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, IntPtr*, uint, int>)(lpVtbl[129]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle, Usage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffscreenPlainSurfaceEx([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DPOOL Pool, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, IntPtr*, uint, int>)(lpVtbl[130]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilSurfaceEx([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, [NativeTypeName("IDirect3DSurface9 **")] IDirect3DSurface9** ppSurface, [NativeTypeName("HANDLE *")] IntPtr* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, int, IDirect3DSurface9**, IntPtr*, uint, int>)(lpVtbl[131]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle, Usage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetEx([NativeTypeName("D3DPRESENT_PARAMETERS *")] D3DPRESENT_PARAMETERS* pPresentationParameters, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pFullscreenDisplayMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, int>)(lpVtbl[132]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters, pFullscreenDisplayMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeEx([NativeTypeName("UINT")] uint iSwapChain, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pMode, [NativeTypeName("D3DDISPLAYROTATION *")] D3DDISPLAYROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[133]))((IDirect3DDevice9Ex*)Unsafe.AsPointer(ref this), iSwapChain, pMode, pRotation);
        }
    }
}
