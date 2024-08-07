// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2"]/*' />
[Guid("0002040F-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICreateTypeLib2 : ICreateTypeLib")]
[NativeInheritance("ICreateTypeLib")]
public unsafe partial struct ICreateTypeLib2 : ICreateTypeLib2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateTypeLib2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint>)(lpVtbl[1]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint>)(lpVtbl[2]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ICreateTypeLib.CreateTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateTypeInfo([NativeTypeName("LPOLESTR")] char* szName, TYPEKIND tkind, ICreateTypeInfo** ppCTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, TYPEKIND, ICreateTypeInfo**, int>)(lpVtbl[3]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetName([NativeTypeName("LPOLESTR")] char* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, int>)(lpVtbl[4]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, ushort, ushort, int>)(lpVtbl[5]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetGuid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, Guid*, int>)(lpVtbl[6]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetDocString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDocString([NativeTypeName("LPOLESTR")] char* szDoc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, int>)(lpVtbl[7]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szDoc);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetHelpFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetHelpFileName([NativeTypeName("LPOLESTR")] char* szHelpFileName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, int>)(lpVtbl[8]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szHelpFileName);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetHelpContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint, int>)(lpVtbl[9]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpContext);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetLcid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLcid([NativeTypeName("LCID")] uint lcid)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint, int>)(lpVtbl[10]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), lcid);
    }

    /// <inheritdoc cref="ICreateTypeLib.SetLibFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLibFlags(uint uLibFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint, int>)(lpVtbl[11]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), uLibFlags);
    }

    /// <inheritdoc cref="ICreateTypeLib.SaveAllChanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SaveAllChanges()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, int>)(lpVtbl[12]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.DeleteTypeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeleteTypeInfo([NativeTypeName("LPOLESTR")] char* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, int>)(lpVtbl[13]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetCustData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, Guid*, VARIANT*, int>)(lpVtbl[14]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetHelpStringContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, uint, int>)(lpVtbl[15]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetHelpStringDll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetHelpStringDll([NativeTypeName("LPOLESTR")] char* szFileName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeLib2*, char*, int>)(lpVtbl[16]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szFileName);
    }

    public interface Interface : ICreateTypeLib.Interface
    {
        [VtblIndex(13)]
        HRESULT DeleteTypeInfo([NativeTypeName("LPOLESTR")] char* szName);

        [VtblIndex(14)]
        HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);

        [VtblIndex(15)]
        HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext);

        [VtblIndex(16)]
        HRESULT SetHelpStringDll([NativeTypeName("LPOLESTR")] char* szFileName);
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

        [NativeTypeName("HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, TYPEKIND, ICreateTypeInfo**, int> CreateTypeInfo;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, int> SetVersion;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetGuid;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetDocString;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetHelpFileName;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetHelpContext;

        [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetLcid;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetLibFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SaveAllChanges;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteTypeInfo;

        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, VARIANT*, int> SetCustData;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetHelpStringContext;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetHelpStringDll;
    }
}
