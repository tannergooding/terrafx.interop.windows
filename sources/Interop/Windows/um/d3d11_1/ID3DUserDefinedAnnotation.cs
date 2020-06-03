// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2DAAD8B-03D4-4DBF-95EB-32AB4B63D0AB")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, Guid*, void**, int>)(lpVtbl[0]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[1]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[2]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("INT")]
        public int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, ushort*, int>)(lpVtbl[3]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("INT")]
        public int EndEvent()
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, int>)(lpVtbl[4]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            ((delegate* stdcall<ID3DUserDefinedAnnotation*, ushort*, void>)(lpVtbl[5]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("BOOL")]
        public int GetStatus()
        {
            return ((delegate* stdcall<ID3DUserDefinedAnnotation*, int>)(lpVtbl[6]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }
    }
}
