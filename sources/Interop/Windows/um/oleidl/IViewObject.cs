// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IViewObject : IUnknown")]
    public unsafe partial struct IViewObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewObject*, Guid*, void**, int>)(lpVtbl[0]))((IViewObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewObject*, uint>)(lpVtbl[1]))((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewObject*, uint>)(lpVtbl[2]))((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hdcTargetDev, [NativeTypeName("HDC")] IntPtr hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* unmanaged<nuint, int> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, IntPtr, IntPtr, RECTL*, RECTL*, delegate* unmanaged<nuint, int>, nuint, int>)(lpVtbl[3]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, LOGPALETTE** ppColorSet)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, DVTARGETDEVICE*, IntPtr, LOGPALETTE**, int>)(lpVtbl[4]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int, void*, uint*, int>)(lpVtbl[5]))((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return ((delegate* unmanaged<IViewObject*, uint, int>)(lpVtbl[6]))((IViewObject*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink)
        {
            return ((delegate* unmanaged<IViewObject*, uint, uint, IAdviseSink*, int>)(lpVtbl[7]))((IViewObject*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, IAdviseSink** ppAdvSink)
        {
            return ((delegate* unmanaged<IViewObject*, uint*, uint*, IAdviseSink**, int>)(lpVtbl[8]))((IViewObject*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }
    }
}
