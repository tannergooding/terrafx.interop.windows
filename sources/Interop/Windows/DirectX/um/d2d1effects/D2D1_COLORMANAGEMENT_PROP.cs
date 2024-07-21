// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP"]/*' />
public enum D2D1_COLORMANAGEMENT_PROP
{
    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT"]/*' />
    D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT = 0,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT"]/*' />
    D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT = 1,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT"]/*' />
    D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT = 2,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT"]/*' />
    D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT = 3,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE"]/*' />
    D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE = 4,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_QUALITY"]/*' />
    D2D1_COLORMANAGEMENT_PROP_QUALITY = 5,

    /// <include file='D2D1_COLORMANAGEMENT_PROP.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_PROP.D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD"]/*' />
    D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
