// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IBindStatusCallbackEx.xml' path='doc/member[@name="IBindStatusCallbackEx"]/*' />
[Guid("AAA74EF9-8EE7-4659-88D9-F8C504DA73CC")]
[NativeTypeName("struct IBindStatusCallbackEx : IBindStatusCallback")]
[NativeInheritance("IBindStatusCallback")]
public unsafe partial struct IBindStatusCallbackEx : IBindStatusCallbackEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindStatusCallbackEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, Guid*, void**, int>)(lpVtbl[0]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint>)(lpVtbl[1]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint>)(lpVtbl[2]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IBindStatusCallback.OnStartBinding" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint, IBinding*, int>)(lpVtbl[3]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), dwReserved, pib);
    }

    /// <inheritdoc cref="IBindStatusCallback.GetPriority" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, int*, int>)(lpVtbl[4]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), pnPriority);
    }

    /// <inheritdoc cref="IBindStatusCallback.OnLowResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint, int>)(lpVtbl[5]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), reserved);
    }

    /// <inheritdoc cref="IBindStatusCallback.OnProgress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint, uint, uint, char*, int>)(lpVtbl[6]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
    }

    /// <inheritdoc cref="IBindStatusCallback.OnStopBinding" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] char* szError)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, HRESULT, char*, int>)(lpVtbl[7]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), hresult, szError);
    }

    /// <inheritdoc cref="IBindStatusCallback.GetBindInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint*, BINDINFO*, int>)(lpVtbl[8]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
    }

    /// <inheritdoc cref="IBindStatusCallback.OnDataAvailable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, FORMATETC* pformatetc, STGMEDIUM* pstgmed)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint, uint, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[9]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
    }

    /// <inheritdoc cref="IBindStatusCallback.OnObjectAvailable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, Guid*, IUnknown*, int>)(lpVtbl[10]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, punk);
    }

    /// <include file='IBindStatusCallbackEx.xml' path='doc/member[@name="IBindStatusCallbackEx.GetBindInfoEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindStatusCallbackEx*, uint*, BINDINFO*, uint*, uint*, int>)(lpVtbl[11]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
    }

    public interface Interface : IBindStatusCallback.Interface
    {
        [VtblIndex(11)]
        HRESULT GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved);
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

        [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBinding*, int> OnStartBinding;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> OnLowResource;

        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, char*, int> OnProgress;

        [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, char*, int> OnStopBinding;

        [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, BINDINFO*, int> GetBindInfo;

        [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, FORMATETC*, STGMEDIUM*, int> OnDataAvailable;

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> OnObjectAvailable;

        [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, BINDINFO*, uint*, uint*, int> GetBindInfoEx;
    }
}
