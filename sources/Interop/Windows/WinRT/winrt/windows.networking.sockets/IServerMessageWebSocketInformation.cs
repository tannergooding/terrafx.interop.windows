// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IServerMessageWebSocketInformation.xml' path='doc/member[@name="IServerMessageWebSocketInformation"]/*' />
[Guid("FC32B45F-4448-5505-6CC9-09AFA8915F5D")]
[NativeTypeName("struct IServerMessageWebSocketInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IServerMessageWebSocketInformation : IServerMessageWebSocketInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IServerMessageWebSocketInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, Guid*, void**, int>)(lpVtbl[0]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, uint>)(lpVtbl[1]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, uint>)(lpVtbl[2]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, HSTRING*, int>)(lpVtbl[4]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, TrustLevel*, int>)(lpVtbl[5]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IServerMessageWebSocketInformation.xml' path='doc/member[@name="IServerMessageWebSocketInformation.get_BandwidthStatistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BandwidthStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")] BandwidthStatistics* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, BandwidthStatistics*, int>)(lpVtbl[6]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerMessageWebSocketInformation.xml' path='doc/member[@name="IServerMessageWebSocketInformation.get_Protocol"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Protocol(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, HSTRING*, int>)(lpVtbl[7]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerMessageWebSocketInformation.xml' path='doc/member[@name="IServerMessageWebSocketInformation.get_LocalAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocketInformation*, IHostName**, int>)(lpVtbl[8]))((IServerMessageWebSocketInformation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BandwidthStatistics([NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")] BandwidthStatistics* value);

        [VtblIndex(7)]
        HRESULT get_Protocol(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LocalAddress([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::BandwidthStatistics *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BandwidthStatistics*, int> get_BandwidthStatistics;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Protocol;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_LocalAddress;
    }
}
