// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MsftStreamPrng001" /> struct.</summary>
public static unsafe partial class MsftStreamPrng001Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftStreamPrng001" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftStreamPrng001).GUID, Is.EqualTo(CLSID_MsftStreamPrng001));
    }
}
