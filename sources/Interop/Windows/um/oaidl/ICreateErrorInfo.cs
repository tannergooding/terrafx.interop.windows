// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F03340-547D-101B-8E65-08002B2BD119")]
    [NativeTypeName("struct ICreateErrorInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICreateErrorInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, uint>)(lpVtbl[1]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, uint>)(lpVtbl[2]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, Guid*, int>)(lpVtbl[3]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int>)(lpVtbl[4]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int>)(lpVtbl[5]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int>)(lpVtbl[6]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateErrorInfo*, uint, int>)(lpVtbl[7]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }
    }
}
