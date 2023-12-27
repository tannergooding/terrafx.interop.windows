// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter"]/*' />
[Guid("BE8C619C-B563-4354-AE33-9FDAAD8C6291")]
[NativeTypeName("struct ICastingDevicePickerFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingDevicePickerFilter : ICastingDevicePickerFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingDevicePickerFilter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, Guid*, void**, int>)(lpVtbl[0]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, uint>)(lpVtbl[1]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, uint>)(lpVtbl[2]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, HSTRING*, int>)(lpVtbl[4]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, TrustLevel*, int>)(lpVtbl[5]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.get_SupportsAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportsAudio([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte*, int>)(lpVtbl[6]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.put_SupportsAudio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SupportsAudio([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte, int>)(lpVtbl[7]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.get_SupportsVideo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportsVideo([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte*, int>)(lpVtbl[8]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.put_SupportsVideo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SupportsVideo([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte, int>)(lpVtbl[9]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.get_SupportsPictures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportsPictures([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte*, int>)(lpVtbl[10]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.put_SupportsPictures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SupportsPictures([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, byte, int>)(lpVtbl[11]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePickerFilter.xml' path='doc/member[@name="ICastingDevicePickerFilter.get_SupportedCastingSources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedCastingSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCasting__CCastingSource_t **")] IVector<Pointer<ICastingSource>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePickerFilter*, IVector<Pointer<ICastingSource>>**, int>)(lpVtbl[12]))((ICastingDevicePickerFilter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportsAudio([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_SupportsAudio([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_SupportsVideo([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_SupportsVideo([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_SupportsPictures([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_SupportsPictures([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_SupportedCastingSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCasting__CCastingSource_t **")] IVector<Pointer<ICastingSource>>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SupportsAudio;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SupportsAudio;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SupportsVideo;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SupportsVideo;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SupportsPictures;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SupportsPictures;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCasting__CCastingSource_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ICastingSource>>**, int> get_SupportedCastingSources;
    }
}
