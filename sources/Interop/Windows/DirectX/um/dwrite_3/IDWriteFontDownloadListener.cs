// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("B06FE5B9-43EC-4393-881B-DBE4DC72FDA7")]
[NativeTypeName("struct IDWriteFontDownloadListener : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IDWriteFontDownloadListener : IDWriteFontDownloadListener.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, uint>)(lpVtbl[1]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, uint>)(lpVtbl[2]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HRESULT downloadResult)
    {
        ((delegate* unmanaged<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, IUnknown*, HRESULT, void>)(lpVtbl[3]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), downloadQueue, context, downloadResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HRESULT downloadResult);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (IDWriteFontDownloadQueue *, IUnknown *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontDownloadQueue*, IUnknown*, HRESULT, void> DownloadCompleted;
    }
}