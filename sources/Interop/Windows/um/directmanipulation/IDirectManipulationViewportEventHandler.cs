// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("952121DA-D69F-45F9-B0F9-F23944321A6D")]
    [NativeTypeName("struct IDirectManipulationViewportEventHandler : IUnknown")]
    public unsafe partial struct IDirectManipulationViewportEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint>)(lpVtbl[1]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint>)(lpVtbl[2]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnViewportStatusChanged(IDirectManipulationViewport* viewport, DIRECTMANIPULATION_STATUS current, DIRECTMANIPULATION_STATUS previous)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, DIRECTMANIPULATION_STATUS, DIRECTMANIPULATION_STATUS, int>)(lpVtbl[3]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport, current, previous);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnViewportUpdated(IDirectManipulationViewport* viewport)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, int>)(lpVtbl[4]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnContentUpdated(IDirectManipulationViewport* viewport, IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, IDirectManipulationContent*, int>)(lpVtbl[5]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport, content);
        }
    }
}
