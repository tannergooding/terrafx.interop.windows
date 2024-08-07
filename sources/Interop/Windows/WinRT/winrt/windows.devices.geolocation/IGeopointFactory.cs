// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeopointFactory.xml' path='doc/member[@name="IGeopointFactory"]/*' />
[Guid("DB6B8D33-76BD-4E30-8AF7-A844DC37B7A0")]
[NativeTypeName("struct IGeopointFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeopointFactory : IGeopointFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeopointFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeopointFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, uint>)(lpVtbl[1]))((IGeopointFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, uint>)(lpVtbl[2]))((IGeopointFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeopointFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, HSTRING*, int>)(lpVtbl[4]))((IGeopointFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeopointFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeopointFactory.xml' path='doc/member[@name="IGeopointFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, BasicGeoposition, IGeopoint**, int>)(lpVtbl[6]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, value);
    }

    /// <include file='IGeopointFactory.xml' path='doc/member[@name="IGeopointFactory.CreateWithAltitudeReferenceSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, BasicGeoposition, AltitudeReferenceSystem, IGeopoint**, int>)(lpVtbl[7]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, altitudeReferenceSystem, value);
    }

    /// <include file='IGeopointFactory.xml' path='doc/member[@name="IGeopointFactory.CreateWithAltitudeReferenceSystemAndSpatialReferenceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeopointFactory*, BasicGeoposition, AltitudeReferenceSystem, uint, IGeopoint**, int>)(lpVtbl[8]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, altitudeReferenceSystem, spatialReferenceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value);

        [VtblIndex(7)]
        HRESULT CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value);

        [VtblIndex(8)]
        HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::IGeopoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, IGeopoint**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeopoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, AltitudeReferenceSystem, IGeopoint**, int> CreateWithAltitudeReferenceSystem;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeopoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, AltitudeReferenceSystem, uint, IGeopoint**, int> CreateWithAltitudeReferenceSystemAndSpatialReferenceId;
    }
}
