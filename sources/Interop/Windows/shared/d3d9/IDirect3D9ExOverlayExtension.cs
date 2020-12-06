// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
    [NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
    public unsafe partial struct IDirect3D9ExOverlayExtension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[1]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint>)(lpVtbl[2]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckDeviceOverlayType([NativeTypeName("UINT")] uint Adapter, D3DDEVTYPE DevType, [NativeTypeName("UINT")] uint OverlayWidth, [NativeTypeName("UINT")] uint OverlayHeight, D3DFORMAT OverlayFormat, [NativeTypeName("D3DDISPLAYMODEEX *")] D3DDISPLAYMODEEX* pDisplayMode, D3DDISPLAYROTATION DisplayRotation, [NativeTypeName("D3DOVERLAYCAPS *")] D3DOVERLAYCAPS* pOverlayCaps)
        {
            return ((delegate* unmanaged<IDirect3D9ExOverlayExtension*, uint, D3DDEVTYPE, uint, uint, D3DFORMAT, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION, D3DOVERLAYCAPS*, int>)(lpVtbl[3]))((IDirect3D9ExOverlayExtension*)Unsafe.AsPointer(ref this), Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
        }
    }
}
