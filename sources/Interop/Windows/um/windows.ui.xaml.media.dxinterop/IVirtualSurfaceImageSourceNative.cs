// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9550983-360B-4F53-B391-AFD695078691")]
    [NativeTypeName("struct IVirtualSurfaceImageSourceNative : ISurfaceImageSourceNative")]
    public unsafe partial struct IVirtualSurfaceImageSourceNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, uint>)(lpVtbl[1]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, uint>)(lpVtbl[2]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDevice(IDXGIDevice* device)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, IDXGIDevice*, int>)(lpVtbl[3]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw(RECT updateRect, IDXGISurface** surface, POINT* offset)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, RECT, IDXGISurface**, POINT*, int>)(lpVtbl[4]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect, surface, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, int>)(lpVtbl[5]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invalidate(RECT updateRect)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, RECT, int>)(lpVtbl[6]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateRectCount([NativeTypeName("DWORD *")] uint* count)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, uint*, int>)(lpVtbl[7]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateRects(RECT* updates, [NativeTypeName("DWORD")] uint count)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, RECT*, uint, int>)(lpVtbl[8]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updates, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVisibleBounds(RECT* bounds)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, RECT*, int>)(lpVtbl[9]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterForUpdatesNeeded(IVirtualSurfaceUpdatesCallbackNative* callback)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, IVirtualSurfaceUpdatesCallbackNative*, int>)(lpVtbl[10]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), callback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("INT")] int newWidth, [NativeTypeName("INT")] int newHeight)
        {
            return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative*, int, int, int>)(lpVtbl[11]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), newWidth, newHeight);
        }
    }
}
