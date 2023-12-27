// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDatagramSocketStatics.xml' path='doc/member[@name="IDatagramSocketStatics"]/*' />
[Guid("E9C62AEE-1494-4A21-BB7E-8589FC751D9D")]
[NativeTypeName("struct IDatagramSocketStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketStatics : IDatagramSocketStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, uint>)(lpVtbl[1]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, uint>)(lpVtbl[2]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, HSTRING*, int>)(lpVtbl[4]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDatagramSocketStatics.xml' path='doc/member[@name="IDatagramSocketStatics.GetEndpointPairsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEndpointPairsAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, IHostName*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>**, int>)(lpVtbl[6]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, operation);
    }

    /// <include file='IDatagramSocketStatics.xml' path='doc/member[@name="IDatagramSocketStatics.GetEndpointPairsWithSortOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEndpointPairsWithSortOptionsAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")] HostNameSortOptions sortOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketStatics*, IHostName*, HSTRING, HostNameSortOptions, IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>**, int>)(lpVtbl[7]))((IDatagramSocketStatics*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, sortOptions, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetEndpointPairsAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>** operation);

        [VtblIndex(7)]
        HRESULT GetEndpointPairsWithSortOptionsAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::HostNameSortOptions")] HostNameSortOptions sortOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>**, int> GetEndpointPairsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Networking::HostNameSortOptions, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CEndpointPair_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, HostNameSortOptions, IAsyncOperation<Pointer<IVectorView<Pointer<IEndpointPair>>>>**, int> GetEndpointPairsWithSortOptionsAsync;
    }
}
