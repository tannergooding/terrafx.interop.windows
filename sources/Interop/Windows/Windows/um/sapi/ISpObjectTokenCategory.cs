// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory"]/*' />
[Guid("2D3D3845-39AF-4850-BBF9-40B49780011D")]
[NativeTypeName("struct ISpObjectTokenCategory : ISpDataKey")]
[NativeInheritance("ISpDataKey")]
public unsafe partial struct ISpObjectTokenCategory : ISpObjectTokenCategory.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, uint>)(lpVtbl[1]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, uint>)(lpVtbl[2]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpDataKey.SetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.GetData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <inheritdoc cref="ISpDataKey.SetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetStringValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <inheritdoc cref="ISpDataKey.SetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, uint, int>)(lpVtbl[7]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <inheritdoc cref="ISpDataKey.GetDWORD" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, uint*, int>)(lpVtbl[8]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <inheritdoc cref="ISpDataKey.OpenKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.CreateKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[11]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <inheritdoc cref="ISpDataKey.DeleteValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[12]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumKeys" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, uint, ushort**, int>)(lpVtbl[13]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <inheritdoc cref="ISpDataKey.EnumValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, uint, ushort**, int>)(lpVtbl[14]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.SetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, BOOL fCreateIfNotExist)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, BOOL, int>)(lpVtbl[15]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszCategoryId, fCreateIfNotExist);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemCategoryId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort**, int>)(lpVtbl[16]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemCategoryId);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetDataKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey** ppDataKey)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, SPDATAKEYLOCATION, ISpDataKey**, int>)(lpVtbl[17]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), spdkl, ppDataKey);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.EnumTokens"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumTokens([NativeTypeName("LPCWSTR")] ushort* pzsReqAttribs, [NativeTypeName("LPCWSTR")] ushort* pszOptAttribs, IEnumSpObjectTokens** ppEnum)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, ushort*, IEnumSpObjectTokens**, int>)(lpVtbl[18]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pzsReqAttribs, pszOptAttribs, ppEnum);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.SetDefaultTokenId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] ushort* pszTokenId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort*, int>)(lpVtbl[19]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), pszTokenId);
    }

    /// <include file='ISpObjectTokenCategory.xml' path='doc/member[@name="ISpObjectTokenCategory.GetDefaultTokenId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId)
    {
        return ((delegate* unmanaged<ISpObjectTokenCategory*, ushort**, int>)(lpVtbl[20]))((ISpObjectTokenCategory*)Unsafe.AsPointer(ref this), ppszCoMemTokenId);
    }

    public interface Interface : ISpDataKey.Interface
    {
        [VtblIndex(15)]
        HRESULT SetId([NativeTypeName("LPCWSTR")] ushort* pszCategoryId, BOOL fCreateIfNotExist);

        [VtblIndex(16)]
        HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemCategoryId);

        [VtblIndex(17)]
        HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, ISpDataKey** ppDataKey);

        [VtblIndex(18)]
        HRESULT EnumTokens([NativeTypeName("LPCWSTR")] ushort* pzsReqAttribs, [NativeTypeName("LPCWSTR")] ushort* pszOptAttribs, IEnumSpObjectTokens** ppEnum);

        [VtblIndex(19)]
        HRESULT SetDefaultTokenId([NativeTypeName("LPCWSTR")] ushort* pszTokenId);

        [VtblIndex(20)]
        HRESULT GetDefaultTokenId([NativeTypeName("LPWSTR *")] ushort** ppszCoMemTokenId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISpDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> EnumValues;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> SetId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetId;

        [NativeTypeName("HRESULT (SPDATAKEYLOCATION, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPDATAKEYLOCATION, ISpDataKey**, int> GetDataKey;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IEnumSpObjectTokens **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IEnumSpObjectTokens**, int> EnumTokens;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDefaultTokenId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDefaultTokenId;
    }
}
