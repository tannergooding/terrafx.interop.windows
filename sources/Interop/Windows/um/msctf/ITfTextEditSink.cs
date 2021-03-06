// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8127D409-CCD3-4683-967A-B43D5B482BF7")]
    [NativeTypeName("struct ITfTextEditSink : IUnknown")]
    public unsafe partial struct ITfTextEditSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextEditSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextEditSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextEditSink*, uint>)(lpVtbl[1]))((ITfTextEditSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextEditSink*, uint>)(lpVtbl[2]))((ITfTextEditSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndEdit(ITfContext* pic, [NativeTypeName("TfEditCookie")] uint ecReadOnly, ITfEditRecord* pEditRecord)
        {
            return ((delegate* unmanaged<ITfTextEditSink*, ITfContext*, uint, ITfEditRecord*, int>)(lpVtbl[3]))((ITfTextEditSink*)Unsafe.AsPointer(ref this), pic, ecReadOnly, pEditRecord);
        }
    }
}
