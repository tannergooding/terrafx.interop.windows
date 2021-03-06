// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6B429B5B-36EF-479E-B9EB-0C1482B49E16")]
    [NativeTypeName("struct IAppxBlockMapBlocksEnumerator : IUnknown")]
    public unsafe partial struct IAppxBlockMapBlocksEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[1]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, uint>)(lpVtbl[2]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxBlockMapBlock** block)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, IAppxBlockMapBlock**, int>)(lpVtbl[3]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, int*, int>)(lpVtbl[4]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlocksEnumerator*, int*, int>)(lpVtbl[5]))((IAppxBlockMapBlocksEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
