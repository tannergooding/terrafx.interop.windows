// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink"]/*' />
[Guid("D594D0D8-8DA7-457B-B3B4-CE5DBAAC0B88")]
[NativeTypeName("struct ITransferAdviseSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITransferAdviseSink : ITransferAdviseSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITransferAdviseSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, Guid*, void**, int>)(lpVtbl[0]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, uint>)(lpVtbl[1]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, uint>)(lpVtbl[2]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.UpdateProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateProgress([NativeTypeName("ULONGLONG")] ulong ullSizeCurrent, [NativeTypeName("ULONGLONG")] ulong ullSizeTotal, int nFilesCurrent, int nFilesTotal, int nFoldersCurrent, int nFoldersTotal)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, ulong, ulong, int, int, int, int, int>)(lpVtbl[3]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), ullSizeCurrent, ullSizeTotal, nFilesCurrent, nFilesTotal, nFoldersCurrent, nFoldersTotal);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.UpdateTransferState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateTransferState([NativeTypeName("TRANSFER_ADVISE_STATE")] uint ts)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, uint, int>)(lpVtbl[4]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), ts);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.ConfirmOverwrite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ConfirmOverwrite(IShellItem* psiSource, IShellItem* psiDestParent, [NativeTypeName("LPCWSTR")] char* pszName)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, IShellItem*, IShellItem*, char*, int>)(lpVtbl[5]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psiSource, psiDestParent, pszName);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.ConfirmEncryptionLoss"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConfirmEncryptionLoss(IShellItem* psiSource)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, IShellItem*, int>)(lpVtbl[6]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psiSource);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.FileFailure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FileFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] char* pszItem, HRESULT hrError, [NativeTypeName("LPWSTR")] char* pszRename, [NativeTypeName("ULONG")] uint cchRename)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, IShellItem*, char*, HRESULT, char*, uint, int>)(lpVtbl[7]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pszItem, hrError, pszRename, cchRename);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.SubStreamFailure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SubStreamFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] char* pszStreamName, HRESULT hrError)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, IShellItem*, char*, HRESULT, int>)(lpVtbl[8]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pszStreamName, hrError);
    }

    /// <include file='ITransferAdviseSink.xml' path='doc/member[@name="ITransferAdviseSink.PropertyFailure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PropertyFailure(IShellItem* psi, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey, HRESULT hrError)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransferAdviseSink*, IShellItem*, PROPERTYKEY*, HRESULT, int>)(lpVtbl[9]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pkey, hrError);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateProgress([NativeTypeName("ULONGLONG")] ulong ullSizeCurrent, [NativeTypeName("ULONGLONG")] ulong ullSizeTotal, int nFilesCurrent, int nFilesTotal, int nFoldersCurrent, int nFoldersTotal);

        [VtblIndex(4)]
        HRESULT UpdateTransferState([NativeTypeName("TRANSFER_ADVISE_STATE")] uint ts);

        [VtblIndex(5)]
        HRESULT ConfirmOverwrite(IShellItem* psiSource, IShellItem* psiDestParent, [NativeTypeName("LPCWSTR")] char* pszName);

        [VtblIndex(6)]
        HRESULT ConfirmEncryptionLoss(IShellItem* psiSource);

        [VtblIndex(7)]
        HRESULT FileFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] char* pszItem, HRESULT hrError, [NativeTypeName("LPWSTR")] char* pszRename, [NativeTypeName("ULONG")] uint cchRename);

        [VtblIndex(8)]
        HRESULT SubStreamFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] char* pszStreamName, HRESULT hrError);

        [VtblIndex(9)]
        HRESULT PropertyFailure(IShellItem* psi, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey, HRESULT hrError);
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

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG, int, int, int, int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, int, int, int, int, int> UpdateProgress;

        [NativeTypeName("HRESULT (TRANSFER_ADVISE_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> UpdateTransferState;

        [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, IShellItem*, char*, int> ConfirmOverwrite;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, int> ConfirmEncryptionLoss;

        [NativeTypeName("HRESULT (IShellItem *, LPCWSTR, HRESULT, LPWSTR, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, char*, HRESULT, char*, uint, int> FileFailure;

        [NativeTypeName("HRESULT (IShellItem *, LPCWSTR, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, char*, HRESULT, int> SubStreamFailure;

        [NativeTypeName("HRESULT (IShellItem *, const PROPERTYKEY *, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, PROPERTYKEY*, HRESULT, int> PropertyFailure;
    }
}
