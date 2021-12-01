// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DWRITE_GLYPH_RUN
{
    public IDWriteFontFace* fontFace;

    public float fontEmSize;

    [NativeTypeName("UINT32")]
    public uint glyphCount;

    [NativeTypeName("const UINT16 *")]
    public ushort* glyphIndices;

    [NativeTypeName("const FLOAT *")]
    public float* glyphAdvances;

    [NativeTypeName("const DWRITE_GLYPH_OFFSET *")]
    public DWRITE_GLYPH_OFFSET* glyphOffsets;

    public BOOL isSideways;

    [NativeTypeName("UINT32")]
    public uint bidiLevel;
}