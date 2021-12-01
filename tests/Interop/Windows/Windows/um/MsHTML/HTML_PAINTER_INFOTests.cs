// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HTML_PAINTER_INFO" /> struct.</summary>
public static unsafe partial class HTML_PAINTER_INFOTests
{
    /// <summary>Validates that the <see cref="HTML_PAINTER_INFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTML_PAINTER_INFO>(), Is.EqualTo(sizeof(HTML_PAINTER_INFO)));
    }

    /// <summary>Validates that the <see cref="HTML_PAINTER_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTML_PAINTER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HTML_PAINTER_INFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTML_PAINTER_INFO), Is.EqualTo(40));
    }
}