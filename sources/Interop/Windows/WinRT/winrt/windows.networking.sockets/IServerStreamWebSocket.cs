// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket"]/*' />
[Guid("2CED5BBF-74F6-55E4-79DF-9132680DFEE8")]
[NativeTypeName("struct IServerStreamWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IServerStreamWebSocket : IServerStreamWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IServerStreamWebSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, Guid*, void**, int>)(lpVtbl[0]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, uint>)(lpVtbl[1]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, uint>)(lpVtbl[2]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, HSTRING*, int>)(lpVtbl[4]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, TrustLevel*, int>)(lpVtbl[5]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IServerStreamWebSocketInformation **")] IServerStreamWebSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, IServerStreamWebSocketInformation**, int>)(lpVtbl[6]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.get_InputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, IInputStream**, int>)(lpVtbl[7]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.get_OutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, IOutputStream**, int>)(lpVtbl[8]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IServerStreamWebSocket>, Pointer<IWebSocketClosedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, ITypedEventHandler<Pointer<IServerStreamWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, EventRegistrationToken, int>)(lpVtbl[10]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IServerStreamWebSocket.xml' path='doc/member[@name="IServerStreamWebSocket.CloseWithStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerStreamWebSocket*, ushort, HSTRING, int>)(lpVtbl[11]))((IServerStreamWebSocket*)Unsafe.AsPointer(ref this), code, reason);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IServerStreamWebSocketInformation **")] IServerStreamWebSocketInformation** value);

        [VtblIndex(7)]
        HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value);

        [VtblIndex(8)]
        HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value);

        [VtblIndex(9)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IServerStreamWebSocket>, Pointer<IWebSocketClosedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IServerStreamWebSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IServerStreamWebSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> get_InputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> get_OutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerStreamWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IServerStreamWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (UINT16, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, HSTRING, int> CloseWithStatus;
    }
}
