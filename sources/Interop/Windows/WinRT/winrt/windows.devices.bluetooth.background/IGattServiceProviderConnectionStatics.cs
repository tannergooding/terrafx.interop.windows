// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderConnectionStatics.xml' path='doc/member[@name="IGattServiceProviderConnectionStatics"]/*' />
[Guid("3D509F4B-0B0E-4466-B8CD-6EBDDA1FA17D")]
[NativeTypeName("struct IGattServiceProviderConnectionStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderConnectionStatics : IGattServiceProviderConnectionStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderConnectionStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, uint>)(lpVtbl[1]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, uint>)(lpVtbl[2]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderConnectionStatics.xml' path='doc/member[@name="IGattServiceProviderConnectionStatics.get_AllServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CDevices__CBluetooth__CBackground__CGattServiceProviderConnection_t **")] IMapView<HSTRING, Pointer<IGattServiceProviderConnection>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnectionStatics*, IMapView<HSTRING, Pointer<IGattServiceProviderConnection>>**, int>)(lpVtbl[6]))((IGattServiceProviderConnectionStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CDevices__CBluetooth__CBackground__CGattServiceProviderConnection_t **")] IMapView<HSTRING, Pointer<IGattServiceProviderConnection>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CDevices__CBluetooth__CBackground__CGattServiceProviderConnection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IGattServiceProviderConnection>>**, int> get_AllServices;
    }
}
