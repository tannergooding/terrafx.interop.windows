// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum MetadataBit
    {
        None = 0,
        IsValueHandle = 0x1,
        IsPropertyReadOnly = 0x2,
        IsValueCollection = 0x4,
        IsValueCollectionReadOnly = 0x8,
        IsValueBindingExpression = 0x10,
        IsValueNull = 0x20,
        IsValueHandleAndEvaluatedValue = 0x40,
    }
}
