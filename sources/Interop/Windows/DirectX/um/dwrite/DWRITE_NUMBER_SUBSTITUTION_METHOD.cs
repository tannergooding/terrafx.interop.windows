// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD"]/*' />
public enum DWRITE_NUMBER_SUBSTITUTION_METHOD
{
    /// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD.DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE"]/*' />
    DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE,

    /// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD.DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL"]/*' />
    DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL,

    /// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD.DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE"]/*' />
    DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE,

    /// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD.DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL"]/*' />
    DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL,

    /// <include file='DWRITE_NUMBER_SUBSTITUTION_METHOD.xml' path='doc/member[@name="DWRITE_NUMBER_SUBSTITUTION_METHOD.DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL"]/*' />
    DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL,
}
