// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata"]/*' />
[Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704")]
[NativeTypeName("struct IMFMetadata : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMetadata : IMFMetadata.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMetadata));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, Guid*, void**, int>)(lpVtbl[0]))((IMFMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, uint>)(lpVtbl[1]))((IMFMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, uint>)(lpVtbl[2]))((IMFMetadata*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.SetLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetLanguage([NativeTypeName("LPCWSTR")] char* pwszRFC1766)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, char*, int>)(lpVtbl[3]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszRFC1766);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.GetLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] char** ppwszRFC1766)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, char**, int>)(lpVtbl[4]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppwszRFC1766);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.GetAllLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAllLanguages(PROPVARIANT* ppvLanguages)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[5]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvLanguages);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.SetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, char*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperty([NativeTypeName("LPCWSTR")] char* pwszName, PROPVARIANT* ppvValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, char*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.DeleteProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteProperty([NativeTypeName("LPCWSTR")] char* pwszName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, char*, int>)(lpVtbl[8]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IMFMetadata.xml' path='doc/member[@name="IMFMetadata.GetAllPropertyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAllPropertyNames(PROPVARIANT* ppvNames)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvNames);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetLanguage([NativeTypeName("LPCWSTR")] char* pwszRFC1766);

        [VtblIndex(4)]
        HRESULT GetLanguage([NativeTypeName("LPWSTR *")] char** ppwszRFC1766);

        [VtblIndex(5)]
        HRESULT GetAllLanguages(PROPVARIANT* ppvLanguages);

        [VtblIndex(6)]
        HRESULT SetProperty([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue);

        [VtblIndex(7)]
        HRESULT GetProperty([NativeTypeName("LPCWSTR")] char* pwszName, PROPVARIANT* ppvValue);

        [VtblIndex(8)]
        HRESULT DeleteProperty([NativeTypeName("LPCWSTR")] char* pwszName);

        [VtblIndex(9)]
        HRESULT GetAllPropertyNames(PROPVARIANT* ppvNames);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetLanguage;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetLanguage;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, int> GetAllLanguages;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> SetProperty;

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> GetProperty;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteProperty;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, int> GetAllPropertyNames;
    }
}
