// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051051A-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTextContentElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTextContentElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint>)(lpVtbl[1]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint>)(lpVtbl[2]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint*, int>)(lpVtbl[3]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_textLength(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_textLength(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_lengthAdjust(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[9]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_lengthAdjust(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[10]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int getNumberOfChars([NativeTypeName("long *")] int* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int*, int>)(lpVtbl[11]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int getComputedTextLength(float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, float*, int>)(lpVtbl[12]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int getSubStringLength([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars, float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, int, float*, int>)(lpVtbl[13]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, nchars, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int getStartPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int>)(lpVtbl[14]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int getEndPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int>)(lpVtbl[15]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int getExtentOfChar([NativeTypeName("long")] int charnum, ISVGRect** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGRect**, int>)(lpVtbl[16]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int getRotationOfChar([NativeTypeName("long")] int charnum, float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, float*, int>)(lpVtbl[17]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int getCharNumAtPosition(ISVGPoint* point, [NativeTypeName("long *")] int* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGPoint*, int*, int>)(lpVtbl[18]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), point, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int selectSubString([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, int, int>)(lpVtbl[19]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, nchars);
        }
    }
}