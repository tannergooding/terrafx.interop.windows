// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2705C288-79AE-11D2-B348-00105A1F8177")]
    [NativeTypeName("struct IWbemHiPerfEnum : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemHiPerfEnum
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, Guid*, void**, int>)(lpVtbl[0]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, uint>)(lpVtbl[1]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, uint>)(lpVtbl[2]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddObjects([NativeTypeName("long")] int lFlags, [NativeTypeName("ULONG")] uint uNumObjects, [NativeTypeName("long *")] int* apIds, IWbemObjectAccess** apObj)
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, int, uint, int*, IWbemObjectAccess**, int>)(lpVtbl[3]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this), lFlags, uNumObjects, apIds, apObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveObjects([NativeTypeName("long")] int lFlags, [NativeTypeName("ULONG")] uint uNumObjects, [NativeTypeName("long *")] int* apIds)
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, int, uint, int*, int>)(lpVtbl[4]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this), lFlags, uNumObjects, apIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjects([NativeTypeName("long")] int lFlags, [NativeTypeName("ULONG")] uint uNumObjects, IWbemObjectAccess** apObj, [NativeTypeName("ULONG *")] uint* puReturned)
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, int, uint, IWbemObjectAccess**, uint*, int>)(lpVtbl[5]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this), lFlags, uNumObjects, apObj, puReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAll([NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemHiPerfEnum*, int, int>)(lpVtbl[6]))((IWbemHiPerfEnum*)Unsafe.AsPointer(ref this), lFlags);
        }
    }
}
