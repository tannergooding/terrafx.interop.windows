// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4C896039-7B6D-49E6-A8C1-45116A98292B")]
    [NativeTypeName("struct IAccClientDocMgr : IUnknown")]
    public unsafe partial struct IAccClientDocMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, Guid*, void**, int>)(lpVtbl[0]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, uint>)(lpVtbl[1]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, uint>)(lpVtbl[2]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocuments(IEnumUnknown** enumUnknown)
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, IEnumUnknown**, int>)(lpVtbl[3]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), enumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LookupByHWND([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, IntPtr, Guid*, IUnknown**, int>)(lpVtbl[4]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), hWnd, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, POINT, Guid*, IUnknown**, int>)(lpVtbl[5]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), pt, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IAccClientDocMgr*, Guid*, IUnknown**, int>)(lpVtbl[6]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), riid, ppunk);
        }
    }
}
