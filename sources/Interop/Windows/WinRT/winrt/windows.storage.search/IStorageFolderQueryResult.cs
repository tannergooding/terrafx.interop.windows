// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFolderQueryResult.xml' path='doc/member[@name="IStorageFolderQueryResult"]/*' />
[Guid("6654C911-7D66-46FA-AECF-E4A4BAA93AB8")]
[NativeTypeName("struct IStorageFolderQueryResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFolderQueryResult : IStorageFolderQueryResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFolderQueryResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, uint>)(lpVtbl[1]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, uint>)(lpVtbl[2]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, HSTRING*, int>)(lpVtbl[4]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFolderQueryResult.xml' path='doc/member[@name="IStorageFolderQueryResult.GetFoldersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFoldersAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxNumberOfItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int>)(lpVtbl[6]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), startIndex, maxNumberOfItems, operation);
    }

    /// <include file='IStorageFolderQueryResult.xml' path='doc/member[@name="IStorageFolderQueryResult.GetFoldersAsyncDefaultStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFoldersAsyncDefaultStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolderQueryResult*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int>)(lpVtbl[7]))((IStorageFolderQueryResult*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetFoldersAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxNumberOfItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation);

        [VtblIndex(7)]
        HRESULT GetFoldersAsyncDefaultStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>** operation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int> GetFoldersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFolder>>>>**, int> GetFoldersAsyncDefaultStartAndCount;
    }
}
