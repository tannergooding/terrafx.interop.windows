// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED8C108D-4349-11D2-91A4-00C04F7969E8")]
    [NativeTypeName("struct IXMLHttpRequest : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLHttpRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, Guid*, void**, int>)(lpVtbl[0]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, uint>)(lpVtbl[1]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, uint>)(lpVtbl[2]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, uint*, int>)(lpVtbl[3]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] ushort* bstrMethod, [NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort*, ushort*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[7]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setRequestHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR")] ushort* bstrValue)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort*, ushort*, int>)(lpVtbl[8]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, bstrValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int getResponseHeader([NativeTypeName("BSTR")] ushort* bstrHeader, [NativeTypeName("BSTR *")] ushort** pbstrValue)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort*, ushort**, int>)(lpVtbl[9]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), bstrHeader, pbstrValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getAllResponseHeaders([NativeTypeName("BSTR *")] ushort** pbstrHeaders)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort**, int>)(lpVtbl[10]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int send(VARIANT varBody)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, VARIANT, int>)(lpVtbl[11]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), varBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, int>)(lpVtbl[12]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("long *")] int* plStatus)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, int*, int>)(lpVtbl[13]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_statusText([NativeTypeName("BSTR *")] ushort** pbstrStatus)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort**, int>)(lpVtbl[14]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseXML(IDispatch** ppBody)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, IDispatch**, int>)(lpVtbl[15]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), ppBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseText([NativeTypeName("BSTR *")] ushort** pbstrBody)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, ushort**, int>)(lpVtbl[16]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pbstrBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseBody(VARIANT* pvarBody)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, VARIANT*, int>)(lpVtbl[17]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_responseStream(VARIANT* pvarBody)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, VARIANT*, int>)(lpVtbl[18]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pvarBody);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* plState)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, int*, int>)(lpVtbl[19]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), plState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(IDispatch* pReadyStateSink)
        {
            return ((delegate* unmanaged<IXMLHttpRequest*, IDispatch*, int>)(lpVtbl[20]))((IXMLHttpRequest*)Unsafe.AsPointer(ref this), pReadyStateSink);
        }
    }
}
