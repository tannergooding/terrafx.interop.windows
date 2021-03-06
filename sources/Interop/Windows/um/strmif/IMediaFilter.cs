// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86899-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaFilter : IPersist")]
    public unsafe partial struct IMediaFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaFilter*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaFilter*, uint>)(lpVtbl[1]))((IMediaFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaFilter*, uint>)(lpVtbl[2]))((IMediaFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IMediaFilter*, Guid*, int>)(lpVtbl[3]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IMediaFilter*, int>)(lpVtbl[4]))((IMediaFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMediaFilter*, int>)(lpVtbl[5]))((IMediaFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("REFERENCE_TIME")] long tStart)
        {
            return ((delegate* unmanaged<IMediaFilter*, long, int>)(lpVtbl[6]))((IMediaFilter*)Unsafe.AsPointer(ref this), tStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
        {
            return ((delegate* unmanaged<IMediaFilter*, uint, FILTER_STATE*, int>)(lpVtbl[7]))((IMediaFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncSource(IReferenceClock* pClock)
        {
            return ((delegate* unmanaged<IMediaFilter*, IReferenceClock*, int>)(lpVtbl[8]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncSource(IReferenceClock** pClock)
        {
            return ((delegate* unmanaged<IMediaFilter*, IReferenceClock**, int>)(lpVtbl[9]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClock);
        }
    }
}
