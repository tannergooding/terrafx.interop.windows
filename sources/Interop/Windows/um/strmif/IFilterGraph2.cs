// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73882-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IFilterGraph2 : IGraphBuilder")]
    public unsafe partial struct IFilterGraph2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFilterGraph2*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFilterGraph2*, uint>)(lpVtbl[1]))((IFilterGraph2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFilterGraph2*, uint>)(lpVtbl[2]))((IFilterGraph2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph2*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFilter(IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph2*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFilters(IEnumFilters** ppEnum)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph2*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph2*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconnect(IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, int>)(lpVtbl[8]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect(IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, int>)(lpVtbl[9]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSyncSource()
        {
            return ((delegate* unmanaged<IFilterGraph2*, int>)(lpVtbl[10]))((IFilterGraph2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IPin* ppinOut, IPin* ppinIn)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, IPin*, int>)(lpVtbl[11]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Render(IPin* ppinOut)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, int>)(lpVtbl[12]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppinOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
        {
            return ((delegate* unmanaged<IFilterGraph2*, ushort*, ushort*, int>)(lpVtbl[13]))((IFilterGraph2*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph2*, ushort*, ushort*, IBaseFilter**, int>)(lpVtbl[14]))((IFilterGraph2*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
        {
            return ((delegate* unmanaged<IFilterGraph2*, nuint, int>)(lpVtbl[15]))((IFilterGraph2*)Unsafe.AsPointer(ref this), hFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* unmanaged<IFilterGraph2*, int>)(lpVtbl[16]))((IFilterGraph2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldOperationContinue()
        {
            return ((delegate* unmanaged<IFilterGraph2*, int>)(lpVtbl[17]))((IFilterGraph2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilterForMoniker(IMoniker* pMoniker, IBindCtx* pCtx, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int>)(lpVtbl[18]))((IFilterGraph2*)Unsafe.AsPointer(ref this), pMoniker, pCtx, lpcwstrFilterName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReconnectEx(IPin* ppin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[19]))((IFilterGraph2*)Unsafe.AsPointer(ref this), ppin, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderEx(IPin* pPinOut, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pvContext)
        {
            return ((delegate* unmanaged<IFilterGraph2*, IPin*, uint, uint*, int>)(lpVtbl[20]))((IFilterGraph2*)Unsafe.AsPointer(ref this), pPinOut, dwFlags, pvContext);
        }
    }
}
