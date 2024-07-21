// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactSignificantOther.xml' path='doc/member[@name="IContactSignificantOther"]/*' />
[Guid("8873B5AB-C5FB-46D8-93FE-DA3FF1934054")]
[NativeTypeName("struct IContactSignificantOther : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactSignificantOther : IContactSignificantOther.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactSignificantOther));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, Guid*, void**, int>)(lpVtbl[0]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, uint>)(lpVtbl[1]))((IContactSignificantOther*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, uint>)(lpVtbl[2]))((IContactSignificantOther*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, uint*, Guid**, int>)(lpVtbl[3]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, HSTRING*, int>)(lpVtbl[4]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, TrustLevel*, int>)(lpVtbl[5]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactSignificantOther.xml' path='doc/member[@name="IContactSignificantOther.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, HSTRING*, int>)(lpVtbl[6]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactSignificantOther.xml' path='doc/member[@name="IContactSignificantOther.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, HSTRING, int>)(lpVtbl[7]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactSignificantOther.xml' path='doc/member[@name="IContactSignificantOther.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, HSTRING*, int>)(lpVtbl[8]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactSignificantOther.xml' path='doc/member[@name="IContactSignificantOther.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactSignificantOther*, HSTRING, int>)(lpVtbl[9]))((IContactSignificantOther*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Description(HSTRING value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
