// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_DECIMAL_TEXT.xml' path='doc/member[@name="WS_XML_DECIMAL_TEXT"]/*' />
public partial struct WS_XML_DECIMAL_TEXT
{
    /// <include file='WS_XML_DECIMAL_TEXT.xml' path='doc/member[@name="WS_XML_DECIMAL_TEXT.text"]/*' />
    public WS_XML_TEXT text;

    /// <include file='WS_XML_DECIMAL_TEXT.xml' path='doc/member[@name="WS_XML_DECIMAL_TEXT.value"]/*' />
    public DECIMAL value;
}