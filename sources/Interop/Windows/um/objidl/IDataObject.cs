// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDataObject : IUnknown")]
    public unsafe partial struct IDataObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataObject*, Guid*, void**, int>)(lpVtbl[0]))((IDataObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataObject*, uint>)(lpVtbl[1]))((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataObject*, uint>)(lpVtbl[2]))((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(FORMATETC* pformatetcIn, STGMEDIUM* pmedium)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[3]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetcIn, pmedium);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataHere(FORMATETC* pformatetc, STGMEDIUM* pmedium)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[4]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryGetData(FORMATETC* pformatetc)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, int>)(lpVtbl[5]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalFormatEtc(FORMATETC* pformatectIn, FORMATETC* pformatetcOut)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, FORMATETC*, int>)(lpVtbl[6]))((IDataObject*)Unsafe.AsPointer(ref this), pformatectIn, pformatetcOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, STGMEDIUM*, int, int>)(lpVtbl[7]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFormatEtc([NativeTypeName("DWORD")] uint dwDirection, IEnumFORMATETC** ppenumFormatEtc)
        {
            return ((delegate* unmanaged<IDataObject*, uint, IEnumFORMATETC**, int>)(lpVtbl[8]))((IDataObject*)Unsafe.AsPointer(ref this), dwDirection, ppenumFormatEtc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DAdvise(FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)(lpVtbl[9]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, advf, pAdvSink, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DUnadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged<IDataObject*, uint, int>)(lpVtbl[10]))((IDataObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged<IDataObject*, IEnumSTATDATA**, int>)(lpVtbl[11]))((IDataObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }
    }
}
