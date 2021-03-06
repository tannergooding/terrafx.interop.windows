// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C4B1FE1B-6E84-47D5-B54C-A597981B06AD")]
    [NativeTypeName("struct IDWriteFontFace6 : IDWriteFontFace5")]
    public unsafe partial struct IDWriteFontFace6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[1]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[2]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_FACE_TYPE>)(lpVtbl[3]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[5]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[6]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[7]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_METRICS*, void>)(lpVtbl[8]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort>)(lpVtbl[9]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[10]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, void**, uint*, void**, int*, int>)(lpVtbl[12]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseFontTable(void* tableContext)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, void*, void>)(lpVtbl[13]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), tableContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, int, int, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int>)(lpVtbl[15]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int>)(lpVtbl[16]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, int, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[17]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[18]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS1* fontMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int>)(lpVtbl[19]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_CARET_METRICS*, void>)(lpVtbl[20]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), caretMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[22]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, int*, int, int>)(lpVtbl[23]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, int, int, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[26]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int>)(lpVtbl[27]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[29]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[30]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetColorPaletteCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[31]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetPaletteEntryCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[32]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, uint, uint, DXGI_RGBA*, int>)(lpVtbl[33]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[34]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPanose(DWRITE_PANOSE* panose)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_PANOSE*, void>)(lpVtbl[36]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), panose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_WEIGHT>)(lpVtbl[37]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_STRETCH>)(lpVtbl[38]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_STYLE>)(lpVtbl[39]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames(IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[42]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, int>)(lpVtbl[43]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE1* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[44]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint, int>)(lpVtbl[45]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort, int>)(lpVtbl[46]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreCharactersLocal([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, int, int*, int>)(lpVtbl[47]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort*, uint, int, int*, int>)(lpVtbl[48]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_GLYPH_IMAGE_FORMATS>)(lpVtbl[50]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageFormats([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEmFirst, [NativeTypeName("UINT32")] uint pixelsPerEmLast, DWRITE_GLYPH_IMAGE_FORMATS* glyphImageFormats)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort, uint, uint, DWRITE_GLYPH_IMAGE_FORMATS*, int>)(lpVtbl[49]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageData([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, DWRITE_GLYPH_IMAGE_DATA* glyphData, void** glyphDataContext)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, ushort, uint, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA*, void**, int>)(lpVtbl[51]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseGlyphImageData(void* glyphDataContext)
        {
            ((delegate* unmanaged<IDWriteFontFace6*, void*, void>)(lpVtbl[52]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphDataContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, uint>)(lpVtbl[53]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[54]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasVariations()
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, int>)(lpVtbl[55]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontResource(IDWriteFontResource** fontResource)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int Equals(IDWriteFontFace* fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, IDWriteFontFace*, int>)(lpVtbl[57]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int>)(lpVtbl[58]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace6*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int>)(lpVtbl[59]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
        }
    }
}
