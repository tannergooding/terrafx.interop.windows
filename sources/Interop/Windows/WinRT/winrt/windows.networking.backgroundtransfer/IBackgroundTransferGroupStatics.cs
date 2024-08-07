// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferGroupStatics.xml' path='doc/member[@name="IBackgroundTransferGroupStatics"]/*' />
[Guid("02EC50B2-7D18-495B-AA22-32A97D45D3E2")]
[NativeTypeName("struct IBackgroundTransferGroupStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferGroupStatics : IBackgroundTransferGroupStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferGroupStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, uint>)(lpVtbl[1]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, uint>)(lpVtbl[2]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferGroupStatics.xml' path='doc/member[@name="IBackgroundTransferGroupStatics.CreateGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateGroup(HSTRING name, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **")] IBackgroundTransferGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroupStatics*, HSTRING, IBackgroundTransferGroup**, int>)(lpVtbl[6]))((IBackgroundTransferGroupStatics*)Unsafe.AsPointer(ref this), name, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateGroup(HSTRING name, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **")] IBackgroundTransferGroup** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBackgroundTransferGroup**, int> CreateGroup;
    }
}
