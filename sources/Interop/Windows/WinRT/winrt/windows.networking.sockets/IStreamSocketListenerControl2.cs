// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2"]/*' />
[Guid("948BB665-2C3E-404B-B8B0-8EB249A2B0A1")]
[NativeTypeName("struct IStreamSocketListenerControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketListenerControl2 : IStreamSocketListenerControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketListenerControl2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, uint>)(lpVtbl[1]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, uint>)(lpVtbl[2]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.get_NoDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte*, int>)(lpVtbl[6]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.put_NoDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NoDelay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte, int>)(lpVtbl[7]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.get_KeepAlive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte*, int>)(lpVtbl[8]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.put_KeepAlive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte, int>)(lpVtbl[9]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.get_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, uint*, int>)(lpVtbl[10]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.put_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, uint, int>)(lpVtbl[11]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.get_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_OutboundUnicastHopLimit(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte*, int>)(lpVtbl[12]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListenerControl2.xml' path='doc/member[@name="IStreamSocketListenerControl2.put_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_OutboundUnicastHopLimit(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListenerControl2*, byte, int>)(lpVtbl[13]))((IStreamSocketListenerControl2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_NoDelay([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_OutboundUnicastHopLimit(byte* value);

        [VtblIndex(13)]
        HRESULT put_OutboundUnicastHopLimit(byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NoDelay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_NoDelay;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeepAlive;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeepAlive;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OutboundUnicastHopLimit;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_OutboundUnicastHopLimit;
    }
}
