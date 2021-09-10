// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4998735C-3A19-473C-9781-656847E3A347")]
    [NativeTypeName("struct ID2D1BorderTransform : ID2D1ConcreteTransform")]
    [NativeInheritance("ID2D1ConcreteTransform")]
    public unsafe partial struct ID2D1BorderTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, uint>)(lpVtbl[1]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, uint>)(lpVtbl[2]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, uint>)(lpVtbl[3]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(lpVtbl[4]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            ((delegate* unmanaged<ID2D1BorderTransform*, int, void>)(lpVtbl[5]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), isCached);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetExtendModeX(D2D1_EXTEND_MODE extendMode)
        {
            ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE, void>)(lpVtbl[6]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void SetExtendModeY(D2D1_EXTEND_MODE extendMode)
        {
            ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE, void>)(lpVtbl[7]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this), extendMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE>)(lpVtbl[8]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            return ((delegate* unmanaged<ID2D1BorderTransform*, D2D1_EXTEND_MODE>)(lpVtbl[9]))((ID2D1BorderTransform*)Unsafe.AsPointer(ref this));
        }
    }
}
