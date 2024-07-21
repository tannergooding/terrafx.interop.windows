// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer"]/*' />
[Guid("484F626E-D3C9-4111-B3F6-2CF1FAA418D5")]
[NativeTypeName("struct IMagnetometer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMagnetometer : IMagnetometer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMagnetometer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, Guid*, void**, int>)(lpVtbl[0]))((IMagnetometer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint>)(lpVtbl[1]))((IMagnetometer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint>)(lpVtbl[2]))((IMagnetometer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint*, Guid**, int>)(lpVtbl[3]))((IMagnetometer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, HSTRING*, int>)(lpVtbl[4]))((IMagnetometer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, TrustLevel*, int>)(lpVtbl[5]))((IMagnetometer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.GetCurrentReading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IMagnetometerReading **")] IMagnetometerReading** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, IMagnetometerReading**, int>)(lpVtbl[6]))((IMagnetometer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.get_MinimumReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint*, int>)(lpVtbl[7]))((IMagnetometer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.put_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint, int>)(lpVtbl[8]))((IMagnetometer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.get_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, uint*, int>)(lpVtbl[9]))((IMagnetometer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CMagnetometer_Windows__CDevices__CSensors__CMagnetometerReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMagnetometer>, Pointer<IMagnetometerReadingChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, ITypedEventHandler<Pointer<IMagnetometer>, Pointer<IMagnetometerReadingChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMagnetometer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMagnetometer.xml' path='doc/member[@name="IMagnetometer.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometer*, EventRegistrationToken, int>)(lpVtbl[11]))((IMagnetometer*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IMagnetometerReading **")] IMagnetometerReading** value);

        [VtblIndex(7)]
        HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CMagnetometer_Windows__CDevices__CSensors__CMagnetometerReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMagnetometer>, Pointer<IMagnetometerReadingChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IMagnetometerReading **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMagnetometerReading**, int> GetCurrentReading;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinimumReportInterval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ReportInterval;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CMagnetometer_Windows__CDevices__CSensors__CMagnetometerReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMagnetometer>, Pointer<IMagnetometerReadingChangedEventArgs>>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }
}
