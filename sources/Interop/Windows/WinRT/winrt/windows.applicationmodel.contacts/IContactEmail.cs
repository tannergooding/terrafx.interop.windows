// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail"]/*' />
[Guid("90A219A9-E3D3-4D63-993B-05B9A5393ABF")]
[NativeTypeName("struct IContactEmail : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactEmail : IContactEmail.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactEmail));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, Guid*, void**, int>)(lpVtbl[0]))((IContactEmail*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, uint>)(lpVtbl[1]))((IContactEmail*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, uint>)(lpVtbl[2]))((IContactEmail*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, uint*, Guid**, int>)(lpVtbl[3]))((IContactEmail*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, HSTRING*, int>)(lpVtbl[4]))((IContactEmail*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, TrustLevel*, int>)(lpVtbl[5]))((IContactEmail*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.get_Address"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Address(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, HSTRING*, int>)(lpVtbl[6]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.put_Address"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Address(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, HSTRING, int>)(lpVtbl[7]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactEmailKind *")] ContactEmailKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, ContactEmailKind*, int>)(lpVtbl[8]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactEmailKind")] ContactEmailKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, ContactEmailKind, int>)(lpVtbl[9]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, HSTRING*, int>)(lpVtbl[10]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactEmail.xml' path='doc/member[@name="IContactEmail.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactEmail*, HSTRING, int>)(lpVtbl[11]))((IContactEmail*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Address(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Address(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactEmailKind *")] ContactEmailKind* value);

        [VtblIndex(9)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactEmailKind")] ContactEmailKind value);

        [VtblIndex(10)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(11)]
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Address;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Address;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactEmailKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactEmailKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactEmailKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactEmailKind, int> put_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
