// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGAnimatedTransformList.xml' path='doc/member[@name="ISVGAnimatedTransformList"]/*' />
[Guid("305104F9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGAnimatedTransformList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGAnimatedTransformList : ISVGAnimatedTransformList.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, uint>)(lpVtbl[1]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, uint>)(lpVtbl[2]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, uint*, int>)(lpVtbl[3]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGAnimatedTransformList.xml' path='doc/member[@name="ISVGAnimatedTransformList.putref_baseVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_baseVal(ISVGTransformList* v)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, ISVGTransformList*, int>)(lpVtbl[7]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAnimatedTransformList.xml' path='doc/member[@name="ISVGAnimatedTransformList.get_baseVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_baseVal(ISVGTransformList** p)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, ISVGTransformList**, int>)(lpVtbl[8]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAnimatedTransformList.xml' path='doc/member[@name="ISVGAnimatedTransformList.putref_animVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_animVal(ISVGTransformList* v)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, ISVGTransformList*, int>)(lpVtbl[9]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAnimatedTransformList.xml' path='doc/member[@name="ISVGAnimatedTransformList.get_animVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_animVal(ISVGTransformList** p)
    {
        return ((delegate* unmanaged<ISVGAnimatedTransformList*, ISVGTransformList**, int>)(lpVtbl[10]))((ISVGAnimatedTransformList*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_baseVal(ISVGTransformList* v);

        [VtblIndex(8)]
        HRESULT get_baseVal(ISVGTransformList** p);

        [VtblIndex(9)]
        HRESULT putref_animVal(ISVGTransformList* v);

        [VtblIndex(10)]
        HRESULT get_animVal(ISVGTransformList** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (ISVGTransformList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransformList*, int> putref_baseVal;

        [NativeTypeName("HRESULT (ISVGTransformList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransformList**, int> get_baseVal;

        [NativeTypeName("HRESULT (ISVGTransformList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransformList*, int> putref_animVal;

        [NativeTypeName("HRESULT (ISVGTransformList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransformList**, int> get_animVal;
    }
}