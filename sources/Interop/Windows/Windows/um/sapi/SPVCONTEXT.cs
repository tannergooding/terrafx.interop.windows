// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT"]/*' />
public unsafe partial struct SPVCONTEXT
{
    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pCategory"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pCategory;

    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pBefore"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pBefore;

    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pAfter"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pAfter;
}
