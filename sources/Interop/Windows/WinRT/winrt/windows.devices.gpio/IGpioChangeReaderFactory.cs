// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioChangeReaderFactory.xml' path='doc/member[@name="IGpioChangeReaderFactory"]/*' />
[Guid("A9598EF3-390E-441A-9D1C-E8DE0B2DF0DF")]
[NativeTypeName("struct IGpioChangeReaderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeReaderFactory : IGpioChangeReaderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeReaderFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, uint>)(lpVtbl[1]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, uint>)(lpVtbl[2]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, HSTRING*, int>)(lpVtbl[4]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioChangeReaderFactory.xml' path='doc/member[@name="IGpioChangeReaderFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeReader **")] IGpioChangeReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, IGpioPin*, IGpioChangeReader**, int>)(lpVtbl[6]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), pin, value);
    }

    /// <include file='IGpioChangeReaderFactory.xml' path='doc/member[@name="IGpioChangeReaderFactory.CreateWithCapacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithCapacity([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("INT32")] int minCapacity, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeReader **")] IGpioChangeReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReaderFactory*, IGpioPin*, int, IGpioChangeReader**, int>)(lpVtbl[7]))((IGpioChangeReaderFactory*)Unsafe.AsPointer(ref this), pin, minCapacity, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeReader **")] IGpioChangeReader** value);

        [VtblIndex(7)]
        HRESULT CreateWithCapacity([NativeTypeName("ABI::Windows::Devices::Gpio::IGpioPin *")] IGpioPin* pin, [NativeTypeName("INT32")] int minCapacity, [NativeTypeName("ABI::Windows::Devices::Gpio::IGpioChangeReader **")] IGpioChangeReader** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::IGpioPin *, ABI::Windows::Devices::Gpio::IGpioChangeReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGpioPin*, IGpioChangeReader**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::IGpioPin *, INT32, ABI::Windows::Devices::Gpio::IGpioChangeReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGpioPin*, int, IGpioChangeReader**, int> CreateWithCapacity;
    }
}