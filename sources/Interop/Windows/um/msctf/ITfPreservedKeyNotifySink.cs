// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F77C993-D2B1-446E-853E-5912EFC8A286")]
    [NativeTypeName("struct ITfPreservedKeyNotifySink : IUnknown")]
    public unsafe partial struct ITfPreservedKeyNotifySink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, uint>)(lpVtbl[1]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, uint>)(lpVtbl[2]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUpdated([NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey)
        {
            return ((delegate* unmanaged<ITfPreservedKeyNotifySink*, TF_PRESERVEDKEY*, int>)(lpVtbl[3]))((ITfPreservedKeyNotifySink*)Unsafe.AsPointer(ref this), pprekey);
        }
    }
}
