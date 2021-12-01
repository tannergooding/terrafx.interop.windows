// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='htmlSelectType.xml' path='doc/member[@name="htmlSelectType"]/*' />
public enum htmlSelectType
{
    /// <include file='htmlSelectType.xml' path='doc/member[@name="htmlSelectType.htmlSelectTypeSelectOne"]/*' />
    htmlSelectTypeSelectOne = 1,

    /// <include file='htmlSelectType.xml' path='doc/member[@name="htmlSelectType.htmlSelectTypeSelectMultiple"]/*' />
    htmlSelectTypeSelectMultiple = 2,

    /// <include file='htmlSelectType.xml' path='doc/member[@name="htmlSelectType.htmlSelectType_Max"]/*' />
    htmlSelectType_Max = 2147483647,
}