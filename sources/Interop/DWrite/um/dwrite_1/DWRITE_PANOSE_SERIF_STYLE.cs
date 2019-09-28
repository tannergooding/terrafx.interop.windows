// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Appearance of the serifs. Present for families: 2-text</summary>
    public enum DWRITE_PANOSE_SERIF_STYLE
    {
        DWRITE_PANOSE_SERIF_STYLE_ANY = 0,

        DWRITE_PANOSE_SERIF_STYLE_NO_FIT = 1,

        DWRITE_PANOSE_SERIF_STYLE_COVE = 2,

        DWRITE_PANOSE_SERIF_STYLE_OBTUSE_COVE = 3,

        DWRITE_PANOSE_SERIF_STYLE_SQUARE_COVE = 4,

        DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SQUARE_COVE = 5,

        DWRITE_PANOSE_SERIF_STYLE_SQUARE = 6,

        DWRITE_PANOSE_SERIF_STYLE_THIN = 7,

        DWRITE_PANOSE_SERIF_STYLE_OVAL = 8,

        DWRITE_PANOSE_SERIF_STYLE_EXAGGERATED = 9,

        DWRITE_PANOSE_SERIF_STYLE_TRIANGLE = 10,

        DWRITE_PANOSE_SERIF_STYLE_NORMAL_SANS = 11,

        DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SANS = 12,

        DWRITE_PANOSE_SERIF_STYLE_PERPENDICULAR_SANS = 13,

        DWRITE_PANOSE_SERIF_STYLE_FLARED = 14,

        DWRITE_PANOSE_SERIF_STYLE_ROUNDED = 15,

        DWRITE_PANOSE_SERIF_STYLE_SCRIPT = 16,

        DWRITE_PANOSE_SERIF_STYLE_PERP_SANS = DWRITE_PANOSE_SERIF_STYLE_PERPENDICULAR_SANS,

        DWRITE_PANOSE_SERIF_STYLE_BONE = DWRITE_PANOSE_SERIF_STYLE_OVAL
    }
}