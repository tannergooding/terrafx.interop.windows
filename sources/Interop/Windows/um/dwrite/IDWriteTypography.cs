// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
    [NativeTypeName("struct IDWriteTypography : IUnknown")]
    public unsafe partial struct IDWriteTypography
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTypography*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTypography*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTypography*, uint>)(lpVtbl[1]))((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTypography*, uint>)(lpVtbl[2]))((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFontFeature(DWRITE_FONT_FEATURE fontFeature)
        {
            return ((delegate* unmanaged<IDWriteTypography*, DWRITE_FONT_FEATURE, int>)(lpVtbl[3]))((IDWriteTypography*)Unsafe.AsPointer(ref this), fontFeature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFeatureCount()
        {
            return ((delegate* unmanaged<IDWriteTypography*, uint>)(lpVtbl[4]))((IDWriteTypography*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFeature([NativeTypeName("UINT32")] uint fontFeatureIndex, DWRITE_FONT_FEATURE* fontFeature)
        {
            return ((delegate* unmanaged<IDWriteTypography*, uint, DWRITE_FONT_FEATURE*, int>)(lpVtbl[5]))((IDWriteTypography*)Unsafe.AsPointer(ref this), fontFeatureIndex, fontFeature);
        }
    }
}
