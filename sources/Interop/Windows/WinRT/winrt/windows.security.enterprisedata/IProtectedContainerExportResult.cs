// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectedContainerExportResult.xml' path='doc/member[@name="IProtectedContainerExportResult"]/*' />
[Guid("3948EF95-F7FB-4B42-AFB0-DF70B41543C1")]
[NativeTypeName("struct IProtectedContainerExportResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectedContainerExportResult : IProtectedContainerExportResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectedContainerExportResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, Guid*, void**, int>)(lpVtbl[0]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, uint>)(lpVtbl[1]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, uint>)(lpVtbl[2]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, HSTRING*, int>)(lpVtbl[4]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, TrustLevel*, int>)(lpVtbl[5]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectedContainerExportResult.xml' path='doc/member[@name="IProtectedContainerExportResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectedImportExportStatus *")] ProtectedImportExportStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, ProtectedImportExportStatus*, int>)(lpVtbl[6]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProtectedContainerExportResult.xml' path='doc/member[@name="IProtectedContainerExportResult.get_File"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectedContainerExportResult*, IStorageFile**, int>)(lpVtbl[7]))((IProtectedContainerExportResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectedImportExportStatus *")] ProtectedImportExportStatus* value);

        [VtblIndex(7)]
        HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::EnterpriseData::ProtectedImportExportStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProtectedImportExportStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_File;
    }
}
