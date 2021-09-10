// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D97B5AAC-C792-433C-975D-35C4EADC7A9D")]
    [NativeTypeName("struct IFileSyncMergeHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileSyncMergeHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSyncMergeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSyncMergeHandler*, uint>)(lpVtbl[1]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSyncMergeHandler*, uint>)(lpVtbl[2]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Merge([NativeTypeName("LPCWSTR")] ushort* localFilePath, [NativeTypeName("LPCWSTR")] ushort* serverFilePath, MERGE_UPDATE_STATUS* updateStatus)
        {
            return ((delegate* unmanaged<IFileSyncMergeHandler*, ushort*, ushort*, MERGE_UPDATE_STATUS*, int>)(lpVtbl[3]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), localFilePath, serverFilePath, updateStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ShowResolveConflictUIAsync([NativeTypeName("LPCWSTR")] ushort* localFilePath, [NativeTypeName("HMONITOR")] IntPtr monitorToDisplayOn)
        {
            return ((delegate* unmanaged<IFileSyncMergeHandler*, ushort*, IntPtr, int>)(lpVtbl[4]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), localFilePath, monitorToDisplayOn);
        }
    }
}
