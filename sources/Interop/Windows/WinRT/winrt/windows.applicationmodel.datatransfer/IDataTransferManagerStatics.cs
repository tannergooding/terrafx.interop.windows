// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataTransferManagerStatics.xml' path='doc/member[@name="IDataTransferManagerStatics"]/*' />
[Guid("A9DA01AA-E00E-4CFE-AA44-2DD932DCA3D8")]
[NativeTypeName("struct IDataTransferManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataTransferManagerStatics : IDataTransferManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataTransferManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, uint>)(lpVtbl[1]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, uint>)(lpVtbl[2]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataTransferManagerStatics.xml' path='doc/member[@name="IDataTransferManagerStatics.ShowShareUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowShareUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, int>)(lpVtbl[6]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDataTransferManagerStatics.xml' path='doc/member[@name="IDataTransferManagerStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataTransferManager **")] IDataTransferManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataTransferManagerStatics*, IDataTransferManager**, int>)(lpVtbl[7]))((IDataTransferManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowShareUI();

        [VtblIndex(7)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataTransferManager **")] IDataTransferManager** result);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowShareUI;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataTransferManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataTransferManager**, int> GetForCurrentView;
    }
}
