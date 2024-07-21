// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountProviderSilentReportOperation.xml' path='doc/member[@name="IWebAccountProviderSilentReportOperation"]/*' />
[Guid("E0B545F8-3B0F-44DA-924C-7B18BAAA62A9")]
[NativeTypeName("struct IWebAccountProviderSilentReportOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountProviderSilentReportOperation : IWebAccountProviderSilentReportOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountProviderSilentReportOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, uint>)(lpVtbl[1]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, uint>)(lpVtbl[2]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountProviderSilentReportOperation.xml' path='doc/member[@name="IWebAccountProviderSilentReportOperation.ReportUserInteractionRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReportUserInteractionRequired()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, int>)(lpVtbl[6]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebAccountProviderSilentReportOperation.xml' path='doc/member[@name="IWebAccountProviderSilentReportOperation.ReportUserInteractionRequiredWithError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReportUserInteractionRequiredWithError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *")] IWebProviderError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderSilentReportOperation*, IWebProviderError*, int>)(lpVtbl[7]))((IWebAccountProviderSilentReportOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReportUserInteractionRequired();

        [VtblIndex(7)]
        HRESULT ReportUserInteractionRequiredWithError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *")] IWebProviderError* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportUserInteractionRequired;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderError*, int> ReportUserInteractionRequiredWithError;
    }
}
