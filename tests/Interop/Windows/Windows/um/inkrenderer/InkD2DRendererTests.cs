// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="InkD2DRenderer" /> struct.</summary>
public static unsafe partial class InkD2DRendererTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="InkD2DRenderer" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(InkD2DRenderer).GUID, Is.EqualTo(CLSID_InkD2DRenderer));
    }
}
