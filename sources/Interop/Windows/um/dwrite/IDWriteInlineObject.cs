// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8339FDE3-106F-47AB-8373-1C6295EB10B3")]
    [NativeTypeName("struct IDWriteInlineObject : IUnknown")]
    public unsafe partial struct IDWriteInlineObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, uint>)(lpVtbl[1]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, uint>)(lpVtbl[2]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, int, int, IUnknown*, int>)(lpVtbl[3]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_INLINE_OBJECT_METRICS* metrics)
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_INLINE_OBJECT_METRICS*, int>)(lpVtbl[4]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), metrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[5]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), overhangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBreakConditions(DWRITE_BREAK_CONDITION* breakConditionBefore, DWRITE_BREAK_CONDITION* breakConditionAfter)
        {
            return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_BREAK_CONDITION*, DWRITE_BREAK_CONDITION*, int>)(lpVtbl[6]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), breakConditionBefore, breakConditionAfter);
        }
    }
}
