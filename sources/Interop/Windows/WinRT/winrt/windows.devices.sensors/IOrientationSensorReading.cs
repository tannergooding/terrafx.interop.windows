// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOrientationSensorReading.xml' path='doc/member[@name="IOrientationSensorReading"]/*' />
[Guid("4756C993-6595-4897-BCC6-D537EE757564")]
[NativeTypeName("struct IOrientationSensorReading : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensorReading : IOrientationSensorReading.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOrientationSensorReading));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, Guid*, void**, int>)(lpVtbl[0]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, uint>)(lpVtbl[1]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, uint>)(lpVtbl[2]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, uint*, Guid**, int>)(lpVtbl[3]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, HSTRING*, int>)(lpVtbl[4]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, TrustLevel*, int>)(lpVtbl[5]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOrientationSensorReading.xml' path='doc/member[@name="IOrientationSensorReading.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, WinRTDateTime*, int>)(lpVtbl[6]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOrientationSensorReading.xml' path='doc/member[@name="IOrientationSensorReading.get_RotationMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RotationMatrix([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorRotationMatrix **")] ISensorRotationMatrix** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, ISensorRotationMatrix**, int>)(lpVtbl[7]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOrientationSensorReading.xml' path='doc/member[@name="IOrientationSensorReading.get_Quaternion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Quaternion([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorQuaternion **")] ISensorQuaternion** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensorReading*, ISensorQuaternion**, int>)(lpVtbl[8]))((IOrientationSensorReading*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT get_RotationMatrix([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorRotationMatrix **")] ISensorRotationMatrix** value);

        [VtblIndex(8)]
        HRESULT get_Quaternion([NativeTypeName("ABI::Windows::Devices::Sensors::ISensorQuaternion **")] ISensorQuaternion** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::ISensorRotationMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISensorRotationMatrix**, int> get_RotationMatrix;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::ISensorQuaternion **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISensorQuaternion**, int> get_Quaternion;
    }
}
