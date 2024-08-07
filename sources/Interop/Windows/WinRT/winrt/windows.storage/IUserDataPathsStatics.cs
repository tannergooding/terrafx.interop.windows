// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataPathsStatics.xml' path='doc/member[@name="IUserDataPathsStatics"]/*' />
[Guid("01B29DEF-E062-48A1-8B0C-F2C7A9CA56C0")]
[NativeTypeName("struct IUserDataPathsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataPathsStatics : IUserDataPathsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataPathsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, uint>)(lpVtbl[1]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, uint>)(lpVtbl[2]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, HSTRING*, int>)(lpVtbl[4]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataPathsStatics.xml' path='doc/member[@name="IUserDataPathsStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, IUser*, IUserDataPaths**, int>)(lpVtbl[6]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), user, result);
    }

    /// <include file='IUserDataPathsStatics.xml' path='doc/member[@name="IUserDataPathsStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataPathsStatics*, IUserDataPaths**, int>)(lpVtbl[7]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result);

        [VtblIndex(7)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Storage::IUserDataPaths **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IUserDataPaths**, int> GetForUser;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IUserDataPaths **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserDataPaths**, int> GetDefault;
    }
}
