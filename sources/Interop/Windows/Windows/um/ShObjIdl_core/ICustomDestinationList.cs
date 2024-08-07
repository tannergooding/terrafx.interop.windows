// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList"]/*' />
[Guid("6332DEBF-87B5-4670-90C0-5E57B408A49E")]
[NativeTypeName("struct ICustomDestinationList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICustomDestinationList : ICustomDestinationList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICustomDestinationList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, Guid*, void**, int>)(lpVtbl[0]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, uint>)(lpVtbl[1]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, uint>)(lpVtbl[2]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.SetAppID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, char*, int>)(lpVtbl[3]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszAppID);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.BeginList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginList(uint* pcMinSlots, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, uint*, Guid*, void**, int>)(lpVtbl[4]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pcMinSlots, riid, ppv);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.AppendCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendCategory([NativeTypeName("LPCWSTR")] char* pszCategory, IObjectArray* poa)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, char*, IObjectArray*, int>)(lpVtbl[5]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszCategory, poa);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.AppendKnownCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AppendKnownCategory(KNOWNDESTCATEGORY category)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, KNOWNDESTCATEGORY, int>)(lpVtbl[6]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), category);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.AddUserTasks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddUserTasks(IObjectArray* poa)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, IObjectArray*, int>)(lpVtbl[7]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), poa);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.CommitList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CommitList()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, int>)(lpVtbl[8]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.GetRemovedDestinations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRemovedDestinations([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, Guid*, void**, int>)(lpVtbl[9]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.DeleteList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteList([NativeTypeName("LPCWSTR")] char* pszAppID)
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, char*, int>)(lpVtbl[10]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszAppID);
    }

    /// <include file='ICustomDestinationList.xml' path='doc/member[@name="ICustomDestinationList.AbortList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AbortList()
    {
        return ((delegate* unmanaged[MemberFunction]<ICustomDestinationList*, int>)(lpVtbl[11]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAppID([NativeTypeName("LPCWSTR")] char* pszAppID);

        [VtblIndex(4)]
        HRESULT BeginList(uint* pcMinSlots, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT AppendCategory([NativeTypeName("LPCWSTR")] char* pszCategory, IObjectArray* poa);

        [VtblIndex(6)]
        HRESULT AppendKnownCategory(KNOWNDESTCATEGORY category);

        [VtblIndex(7)]
        HRESULT AddUserTasks(IObjectArray* poa);

        [VtblIndex(8)]
        HRESULT CommitList();

        [VtblIndex(9)]
        HRESULT GetRemovedDestinations([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(10)]
        HRESULT DeleteList([NativeTypeName("LPCWSTR")] char* pszAppID);

        [VtblIndex(11)]
        HRESULT AbortList();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetAppID;

        [NativeTypeName("HRESULT (UINT *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid*, void**, int> BeginList;

        [NativeTypeName("HRESULT (LPCWSTR, IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IObjectArray*, int> AppendCategory;

        [NativeTypeName("HRESULT (KNOWNDESTCATEGORY) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KNOWNDESTCATEGORY, int> AppendKnownCategory;

        [NativeTypeName("HRESULT (IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObjectArray*, int> AddUserTasks;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CommitList;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetRemovedDestinations;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> AbortList;
    }
}
