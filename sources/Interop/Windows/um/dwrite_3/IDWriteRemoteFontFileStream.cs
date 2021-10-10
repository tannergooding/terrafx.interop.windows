// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
    [NativeTypeName("struct IDWriteRemoteFontFileStream : IDWriteFontFileStream")]
    [NativeInheritance("IDWriteFontFileStream")]
    public unsafe partial struct IDWriteRemoteFontFileStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, uint>)(lpVtbl[1]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, uint>)(lpVtbl[2]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, void** fragmentContext)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)(lpVtbl[3]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ReleaseFileFragment(void* fragmentContext)
        {
            ((delegate* unmanaged<IDWriteRemoteFontFileStream*, void*, void>)(lpVtbl[4]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[5]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[6]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int>)(lpVtbl[7]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, [NativeTypeName("BOOL *")] int* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)(lpVtbl[8]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, DWRITE_LOCALITY>)(lpVtbl[9]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, Guid*, DWRITE_FILE_FRAGMENT*, uint, IDWriteAsyncResult**, int>)(lpVtbl[10]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
        }
    }
}
